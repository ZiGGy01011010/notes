## Flow control
Main approaches:  
1. Exceptions
2. OneOf
3. FluentResults
4. ErrorOr & Domain errors
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