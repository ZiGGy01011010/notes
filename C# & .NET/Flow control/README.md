## Flow control
Main approaches:  
- [Exceptions](#exceptions)
- [OneOf package](#oneof-package)
- [FluentResults package](#fluentresults-package)
### Exceptions
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
### OneOf package
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
    OneOf<AuthenticationResult, IError> registerResult = _authenticationService.Register(
      request.FirstName,
      request.LastName,
      request.Email,
      request.Password
    );

    return registerResult.Match(
      authResult => Ok(new AuthenticationResponse(authResult)),
      error => Problem(statusCode: (int)error.StatusCode, title: error.ErrorMassage)
    );
  }
}
```
### FluentResults package
Same approach as OneOf, but instead of one error it contains a lis of errors.
```csharp
public class AuthenticationController : ControllerBase
{
  .
  .
  .
  [HttpPost("register")]
  public IActionResult Register(RegisterRequest request)
  {
    Result<AuthenticationResult> registerResult = _authenticationService.Register(
      request.FirstName,
      request.LastName,
      request.Email,
      request.Password
    );

    if (registerResult.isSuccess)
    {
      return Ok(new AuthenticationResponse(registerResult.Value));
    }
    
    var firstError = registerResult.Errors[0];

    if (firstError is DuplicateEmailError)
    {
      return Problem(statusCode: StatusCodes.Status409Conflict, title: "Email already exists");
    }

    return Problem();
  }
}
```