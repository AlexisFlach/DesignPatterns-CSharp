## State Pattern

Allow an object to alter its behavior when its internal state changes. The object appear to change its class.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0406-01.png" />


#### Participants
---

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:0201633612/files/graphics/pg306fig01.jpg" />

#### Context

Defines the interface of interest to clients

Maintains an instance of a ConcreteState subclass that defines the current state.

#### State 

Defines an interface for encapsulating the behaviour associated with a particular state of the Context.

#### ConcreteState subclasses 

Each subclass implements a behavior associated with a state of the Context.


###### Commands
```
dotnet new sln -o state-pattern
dotnet new classlib -o Gumballs // 
dotnet sln add Gumballs/Gumballs.csproj
dotnet new xunit -o Gumballs.Tests
dotnet sln add Gumballs.Tests/Gumballs.Tests.csproj
dotnet add Gumballs.Tests/Gumballs.Tests.csproj reference Gumballs/Gumballs.csproj
```