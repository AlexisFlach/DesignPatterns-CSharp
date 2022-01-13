## Observer Pattern

The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0057-01.png" alt="headfirst"/>

#### Design Principles

**Identify the aspects of your code that vary and separate them from what stays the same**

What varies in the Observer Pattern is the state of the Subject and the number and types of Observers.

With this pattern we can vary the objects that that are dependent on the state of the object, without having to change that Subject.

**Program to an interface, not an implementation**

We keep things loosely coupled.

**Favor Composition over inheritance**

We compose any number of Observers with their Subject, at runtime by composition.

**Loose Coupling**

Strive for loosely coupled designs between objects that interact. When two objects are loosely coupled, they can interact, but they typically have very little knowledge of each other.

#### Participants

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:0201633612/files/graphics/pg294fig01.jpg">
<br>

**Subject**

Knows its observers. Any number of Observers may observe a subject.
Also provides an interface for attaching and detaching Observer objects.

**Observer**

Defines an updating interfave for objects that should be notified of changes in a subject.

**ConcreteSubject**

Stores state of interest to ConcreteObserver objects.
Sends a notification to its observers when its state changes.

**ConcreteObserver**

Maintains a reference to a ConcreteSubject object.
Stores stat that should stay consistent with the subject's.
Implements the Observer updating interface to keep its state consistent with the subject's.


###### Commands
```
dotnet new sln -o observer-pattern
dotnet new classlib -o WeatherStation
dotnet sln add WeatherStation/WeatherStation.csproj
dotnet new xunit -o WeatherStation.Tests
dotnet sln add WeatherStation.Tests/WeatherStation.Tests.csproj
dotnet add WeatherStation.Tests/WeatherStation.Tests.csproj reference WeatherStation/WeatherStation.csproj
```