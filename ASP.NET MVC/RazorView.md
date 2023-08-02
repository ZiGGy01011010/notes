**Razor** is a markup syntax for embedding **.NET** based code into webpages. The Razor syntax consists of Razor markup, C#, and HTML.

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
For loop:
```cshtml
@for (var i = 0; i < people.Length; i++)
{
    var person = people[i];
    <text>Name: @person.Name</text>
}
```