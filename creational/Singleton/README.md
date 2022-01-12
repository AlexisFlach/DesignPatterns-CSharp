#### Singleton

The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781492077992/files/assets/f0177-01.png">

#### Participants

<img src="https://learning.oreilly.com/api/v2/epubs/urn:orm:book:0201633612/files/graphics/pg127fig01.jpg">

- Singleton

Defines an Instance operation that lets clients access its unique instance.

May be responsible for creating its own unique instance.


###### Commands

```
dotnet new sln -o singleton
cd singleton
dotnet new classlib -o Unique
dotnet sln add Unique/Unique.csproj
dotnet new xunit -o Unique.Tests
dotnet sln add Unique.Tests/Unique.Tests.csproj
dotnet add Unique.Tests/Unique.Tests.csproj reference Unique/Unique.csproj
```