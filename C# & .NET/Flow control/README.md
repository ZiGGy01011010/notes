# Flow control
Main approaches:  
- [Exceptions](#exceptions)
- [OneOf package](#oneof-package)
- [FluentResults package](#fluentresults-package)
- [ErrorOr package](#erroror-package)  

Errors classes can be placed ether in Domain or Application layer.  
[One more thing](#one-more-thing)
## Exceptions
```csharp
//Program.cs
...
var app = builder.Build();
...
app.UseExceptionHandler("/errors");
...
app.Run();
```
Exceptions handling with errors endpoint.
```csharp
public class ErrorsController : ControllerBase
{
  [Route("/errors")]
  public IActionResult Error()
  {
    Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

    return Problem();
  }
}
```
Usually used with a lot of application specific exceptions and giant switch to handle them differently. Other approach is to define an interface for all application exceptions with methods like ErrorCode and ErrorMessage.
## OneOf package
OneOf returns some error or AuthenticationResult.
```csharp
public class AuthenticationController : ControllerBase
{
  .
  .
  .
  [HttpPost("register")]
  public IActionResult Register(RegisterRequest request)
  {
    OneOf<AuthenticationResult, IError> authResult = _authenticationService.Register(
      request.FirstName,
      request.LastName,
      request.Email,
      request.Password
    );

    return authResult.Match(
      authResult => Ok(new AuthenticationResponse(authResult)),
      error => Problem(statusCode: (int)error.StatusCode, title: error.ErrorMassage)
    );
  }
}
```
## FluentResults package
Same approach as OneOf, but instead of one error it contains a list of errors.
```csharp
public class AuthenticationController : ControllerBase
{
  .
  .
  .
  [HttpPost("register")]
  public IActionResult Register(RegisterRequest request)
  {
    Result<AuthenticationResult> authResult = _authenticationService.Register(
      request.FirstName,
      request.LastName,
      request.Email,
      request.Password
    );

    if (authResult.isSuccess)
    {
      return Ok(new AuthenticationResponse(authResult.Value));
    }
    
    var firstError = authResult.Errors[0];

    if (firstError is DuplicateEmailError)
    {
      return Problem(statusCode: StatusCodes.Status409Conflict, title: "Email already exists");
    }

    return Problem();
  }
}
```
```csharp
public class AuthenticationService
{
.
.
.
  public Result<AuthenticationResult> Register(RegisterRequest request)
  {
    //Bad result example
    if (someChecksFail)
    {
      return Result.Fail<AuthenticationResult>(new DuplicateEmailError());
      //or
      //return Result.Fail<AuthenticationResult>(new[] {new DuplicateEmailError()});
      //for list of errors
    }
  }
}
```
## ErrorOr package
Combination of all the things.
```csharp
public class AuthenticationService
{
.
.
.
  public ErrorOr<AuthenticationResult> Register(RegisterRequest request)
  {
    //Bad result example
    if (someChecksFail)
    {
      return Errors.User.DuplicateEmail;
    }
    //List of errors example
    if (someChecksFail)
    {
      return new[] { Errors.User.DuplicateEmail };
    }
    .
    .
    .
    //Good result example
    return new AuthenticationResult(user, token);
  }
}
```
```csharp
public class AuthenticationController : ControllerBase
{
  .
  .
  .
  [HttpPost("register")]
  public IActionResult Register(RegisterRequest request)
  {
    ErrorOr<AuthenticationResult> authResult = _authenticationService.Register(
      request.FirstName,
      request.LastName,
      request.Email,
      request.Password
    );

    return authResult.MatchFirst(
      authResult => Ok(new AuthenticationResponse(authResult)),
      error => Problem(statusCode: (int)error.StatusCode, title: error.ErrorMassage)
    );
  }
}
```
## One more thing
One base controller to inherit from.
```csharp
[ApiController]
public class ApiController : BaseController
{
  protected IActionResult Problem(List<Error> errors)
  {
    //HttpContextItemsKeys just static class with string constants
    HttpContext.Items[HttpContextItemsKeys.errors] = errors;

    var firstError = errors[0];

    var statusCode = firstError.Type switch
    {
      ErrorType.Conflict => StatusCodes.Status409Conflict,
      ErrorType.Validation => StatusCodes.Status400BadRequest,
      ErrorType.NotFound => StatusCodes.Status404NotFound,
      _ => StatusCodes.Status500InternalServeError
    };

    return Problem(statusCode: statusCode, title: firstError.Description);
  }
}
```