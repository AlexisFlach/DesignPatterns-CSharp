#### Decorator

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0092-01.png">

#### Design Principles

- The Open-Closed principle 

Classes should be open for extension, but closed for modification.

#### Participants

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:0201633612/files/graphics/pg177fig01.jpg">

- Component

Defines the interface for objects that can have responsibilities added to them dynamically.

- ConcreteComponent

Defines an object to which additional responsibilities can be attached.

- Decorator

Decorator forwards requests to its Component object. It may optionally perform additional operations before and after forwarding the request.

- ConcreteDecorator

Add responsibilities to the component


###### Commands
```
dotnet new sln -o decorator-pattern
cd decorator-pattern
dotnet new classlib -o Cafe
dotnet sln add Cafe/Cafe.csproj
dotnet new xunit -o Cafe.Tests
dotnet sln add Cafe.Tests/Cafe.Tests.csproj
dotnet add Cafe.Tests/Cafe.Tests.csproj reference Cafe/Cafe.csproj
```
