## List of topics

**OOP**,  
...  
**Boxing/Unboxing**,  
...  
Principles **KISS**, **DRY**, **SOLID** (  
&nbsp;&nbsp;Single-responsibility principle,  
&nbsp;&nbsp;Open–closed principle,  
&nbsp;&nbsp;Liskov substitution principle,  
&nbsp;&nbsp;Interface segregation principle,  
&nbsp;&nbsp;Dependency inversion principle  
&nbsp;&nbsp;),  
**Design patterns** (singleton, Abstract Factory...),  
**Clean architecture** solution (Domain layer, Application/Business layer, Infrastructure/DataAccess layer, Presentation/WebAPI layer),  
**DDD** (Rich domain model, entities related business rules, Aggregates, Entities, Value Objects, Domain events, Domain errors),  
**TDD** (All class dependencies should be exposed through interfaces, for mocking.  
&nbsp;&nbsp;Use xUnit/NUnit, don't use Moq!!! Use NSubstitute instead, fluent assertions),  
**IoC Container** (a.k.a. DI Container),  
**ORM** (Entity Framework and/or Dapper),  
**CQRS** pattern and it's implementation MediatR,  
**mapping** Model <=> DTO (don't use AutoMapper!!! Use Mapperly or manually write extension method for DTO class),  
**Model validation** (attributes, filters, FluentValidation, Model validation inside model class (Rich domain model)?),  
**Error handling** (Use to catch actual exceptions (unexpected errors)!  
&nbsp;&nbsp;For business rules use any methods of flow control.  
&nbsp;&nbsp;Use error endpoint, Problem Details, filters, middleware),  
**Flow control** (ErrorOr & Domain errors, FluentResults)  

### Tools:
**git**  
**Visual Studio**  
**Docker**  