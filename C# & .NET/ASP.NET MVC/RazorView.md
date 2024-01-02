**[Razor](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor)** is a markup syntax for embedding **.NET** based code into webpages. The Razor syntax consists of Razor markup, C#, and HTML.

Model type:
```cshtml
@model project.Areas.Test.Models.PersonModel
```
To escape an @ symbol in Razor markup, use a second @ symbol.
```cshtml
@{
    string message = "C# code framed in {} braces";
}
<h2>Standard HTML code</h2>
```
Comments:
```cshtml
@{
    /* C# comment */
    // Another C# comment
}
@* This is a comment
*@
<!-- HTML comment -->
```
Expressions:
```cshtml
<p>@DateTime.Now</p>
<p>@DateTime.IsLeapYear(2016)</p>
<p>@await DoSomething("hello", "world")</p>
<p>Last week this time: @(DateTime.Now - TimeSpan.FromDays(7))</p>

@{
    //C# code block
    var joe = new Person("Joe", 33);
}

<p>Age@(joe.Age)</p>
<!-- Generic methods should be an explicit expression (), otherwise brackets <> are interpreted as an HTML tag. -->
<p>@(GenericMethod<int>())</p>
```
Conditions:
```cshtml
@if (value % 2 == 0)
{
    <p>The value was even.</p>
}
else if (value >= 1337)
{
    <p>The value is large.</p>
}
else
{
    <p>The value is odd and small.</p>
}
```
Loops:
```cshtml
@for (var i = 0; i < people.Length; i++)
{
    var person = people[i];
    <text>Name: @person.Name</text>
}
@foreach (var customer in Model.customers)
{
    <p>@customer.name</p>
}
@while ...
@do
{
    ...
} while (...);
```
Render attributes dynamically:
```cshtml
@{
    var className = Model.Customers.Count > 5 ? "popular" : null;
}
<h2 class = "@className">@Model.Movie.Name</h2>
@* class attribute will not render if = null *@
```
using:
```cshtml
@using (Html.BeginForm())
{
    <div>
        Email: <input type="email" id="Email" value="">
        <button>Register</button>
    </div>
}
```
try, catch, finally:
```cshtml
@try
{
    throw new InvalidOperationException("You did something invalid.");
}
catch (Exception ex)
{
    <p>The exception message: @ex.Message</p>
}
finally
{
    <p>The finally statement.</p>
}
```
lock:
```cshtml
@lock (SomeLock)
{
    // Do critical section work
}
```
Attribute:
```cshtml
@attribute [Authorize]
```