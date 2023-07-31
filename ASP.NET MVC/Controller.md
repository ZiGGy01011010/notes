## Action Results
| Type | Helper Method | Comment |
| --- | --- | --- |
| ViewResult | View() | Represents HTML and markup. |
| PartialViewResult | PartialView() |
| ContentResult | Content() | Represents a text result. |
| RedirectResult | Redirect() | Represents a redirection to a new URL. |
| RedirectToRouteResult | RedirectToAction() | Represents a redirect to a controller action in an application. |
| JsonResult | Json() | Represents a JavaScript Object Notation result. |
| JavaScriptResult | JavaScriptResult() | Represents a JavaScript script. |
| FileResult | File() | Represents a downloadable file. |
| HttpNotFoundResult | HttpNotFound() | Represents 404 error. |
| EmptyResult |  | Represents no result. |
## Action parameters
To make parameter **optional** you should make it **nullable**.
## Attribute routes
`RouteConfig.cs`:
```csharp
public class RouteConfig
{
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        routes.MapMvcAttributeRoutes();//enables attribute routes

        .
        .
        .
    }
}
```
Controller action:
```csharp
//<area>/<controller>/<route>/<parameter>
[Route("test/testhome/year/{year:regex(\\d{4}):range(2000,2030)}")]
public ActionResult ByYear(int year)
{
    return Content(year.ToString());
}
```
---
Don't use `ViewData[]` or `ViewBag` for passing data to a view, instead use `@model`.

## View Models
In `@model` you can pass only one model. If you need to pass more models just wrap them in a new model, and this is called **View Models**:
```csharp
public class RandomViewModel
{
    public Movie Movie { get; set; }
    public List<Customer> Customers { get; set; }
}
```