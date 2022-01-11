#### Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one and makes them interchangeable. Strategy lets the algorithm vary independendently from clients that use it.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0022-01.png" alt="headfirsr" width="300" />
<br>

#### Design Principles

- Identify the aspects of your application that vary and separate them from what stays the same

- Program to an interface, not an implementation

- Favor composition over inheritance

- The one constant in software development is change



###### Commands

```
dotnet new sln -o strategy-pattern
dotnet new classlib -o DuckSim
dotnet sln add DuckSim/DuckSim.csproj
dotnet new xunit -o DuckSim.Tests
dotnet sln add DuckSim.Tests/DuckSim.Tests.csproj
dotnet add /DuckSim/DuckSim.csproj reference DuckSim.Tests/DuckSim.Tests.csproj
```

###### Sources

https://www.youtube.com/watch?v=v9ejT8FO-7I&ab_channel=ChristopherOkhravi

https://www.amazon.com/Head-First-Design-Patterns-Brain-Friendly/dp/0596007124







