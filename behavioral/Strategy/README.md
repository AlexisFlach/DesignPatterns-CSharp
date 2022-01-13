## Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one and makes them interchangeable. Strategy lets the algorithm vary independendently from clients that use it.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0022-01.png" alt="headfirsr" />
<br>

#### Design Principles
---

**Identify the aspects of your application that vary and separate them from what stays the same**

**Program to an interface, not an implementation**

**Favor composition over inheritance**


#### Participants
---

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:0201633612/files/graphics/pg316fig01.jpg" alt="headfirsr" />
<br>

**Strategy (Compositor)**
Declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a ConcreteStrategy.

**ConcreteStrategy**

Implements the algorithm using the Strategy interface.

**Context (Composition)**

    - Configured with a ConcreteStrategy object.
    - Maintains a reference to a Strategy Object
    - May define an interface that lets Strategy access data

#### Collaborations
---

- Strategy and Context interact to implement the chosen algorithm. A context may pass all data required by the algorithm to the strategy when the algorithm is called. Alternatively, the context can pass itself as an argument to Strategy operations. That lets the strategy call back on the context as required.

- A context forwards requests from its clients to its strategy. Clients usually create and pass a ConcreteStrategy object to the context; thereafter, clients interact with the context exclusively. There is often a family of ConcreteStrategy classes for a client to choose from.


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

https://www.amazon.com/Design-Patterns-Object-Oriented-Addison-Wesley-Professional-ebook/dp/B000SEIBB8