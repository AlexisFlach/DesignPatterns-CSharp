## Command Pattern

The Command Pattern encapsulates a request as an object, thereby letting you parameterize the objects with different requests, queue or loq requests, and support undoable operations.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0207-01.png" />

#### Design Principles
---


#### Participants
---

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:0201633612/files/graphics/pg236fig01.jpg" />

#### Partcipants

**Command**

Declares an interface for executing an operation.

**ConcreteCommand**

- defines a binding between a Receiver object and an action.
- implements execute by invoking the corresponding operation(s) on Receiver

**Client(Application)**

Creates a ConcreteCommand object and sets its receive

**Invoker**

Asks the command to carry out the request.

#### Collaborations
---



###### Commands
```
dotnet new sln -o command-pattern
cd command-pattern
dotnet new classlib -o RemoteControl
dotnet sln add RemoteControl/RemoteControl.csproj
dotnet new xunit -o RemoteControl.Tests
dotnet sln add RemoteControl.Tests/RemoteControl.Tests.csproj
dotnet add RemoteControl.Tests/RemoteControl.Tests.csproj reference RemoteControl/RemoteControl.csproj
```
