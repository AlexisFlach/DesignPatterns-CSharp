# SOLID

#### Single Responsibility Principle

**Every object in your system should have a single responsibility, and all the object's services should be focused on carrying out that single responsibility**.

Man brukar säga att en klass endast ska en anledning till att ändras.

Vi kan sätta ett likhets tecken mellan ansvarsområde och "anledning att till att ändras".

```c#
	public abstract class Car
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract void ChangeTires(Tire tire);
        public abstract void Drive();
        public abstract void Wash();
        public abstract void CheckOil();
        public abstract int GetOil();
    }
```

```c#
    public enum Tire {
        Michelin,
        Continental,
        Pirelli
    }
```

En teknik vi kan använda oss av för att försäkra oss om att vi följer denna princip är att fråga oss vad ansvarsområder för vår klass är. Om vi i svaret säger "och" så bryter vi förmodligen mot principen.

En anna teknik vi kan använda för att se om en klass har flera ansvarsområden är att skriva ned följande och beskriva följande:

```
Bilen startar(Start()) sig själv
Bilen stopar(Stop()) sig själv
Bilen byter däck (ChangeTires(Tire tire)) på sig själv
...
```

Tänk sedan på om det är rimligt att exempelvis en bil byter däck på sig själv. Om det är det bockar vi för exempelvis "Ja, det är rimligt att bilen startar sig själv och metoden kommer att finnas kvar då det följer **Single Responsibility Principle**".

En viktig sak att tänka på när det gäller SRP är att när vi talar om en anledning att ändras, så pratar vi inte om antalet metoder i en klass, utan antal ansvarsområden:

**Klass som följer SRP**

```
    public class StandardMessages
    {
        public static void WelcomeMessage() {
           Console.WriteLine("Welcome to my Application");
        }
        public static void EndApplication()
        {
            Console.Write("Press enter to close");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName) => Console.WriteLine($"Please enter a valid {fieldName}");
    }
```

#### Open/Closed Principle

**Classes should be open for extension but closed for modification**.

**Från**

```
      public static void Run()
        {
            List<Person> _applicants = new List<Person>
        {
            new Person {Name="Hank", },
            new Person {Name="Tank", EmployeeType = EmployeeType.Manager},
            new Person {Name= "Frank", EmployeeType= EmployeeType.Executive}
        };
            List<Employee> _employees = new List<Employee>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in _applicants)
            {
                _employees.Add(accountProcessor.Create(person));
            }
            foreach (var emp in _employees)
            {
                System.Console.WriteLine($"{emp.Name}: {emp.Email}  IsManager: {emp.IsManager}  IsExecutive: {emp.IsExecutive}");
            }
        }
```

**Till**

```
    public class Solution
    {
        public static void Run()
        {
            List<IApplicant> _applicants = new List<IApplicant>
        {
            new Person {Name="Hank", },
            new Executive {Name="Tank"},
            new Manager {Name= "Frank"}
        };
            List<Employee> _employees = new List<Employee>();

            foreach (var person in _applicants)
            {
                _employees.Add(person.AccountProcessor.Create(person));
            }
            foreach (var emp in _employees)
            {
                System.Console.WriteLine($"{emp.Name}: {emp.Email}  IsManager: {emp.IsManager}  IsExecutive: {emp.IsExecutive}");
            }
        }
    }

```



#### Liskow Substititution Principle

**Subtypes must be substitutable for their base types**

Denna princip handlar om väldesignada arv. När vi ärver från en basklass, måste vi kunna byta ut våra subklasser mot den basklassen utan problem.

Det handlar mer om beteende, än attribut.

```
 class HealthyActivity
    {
        public void Enjoy()
        {
            System.Console.WriteLine("I am enjoying this activity!!");
        }
        public virtual void FeelFresh()
        {
            System.Console.WriteLine("This activity is making me feel fresh!!");
        }
    }
```

```
    class SmokingActivity : HealthyActivity
    {
        public void Enjoy()
        {
            System.Console.WriteLine("I am enjoying this activity!!");
        }
        public override void FeelFresh()
        {
            throw new InvalidOperationException("Smoking doesn't make you feel fresh");
        }
    }
```

```
            HealthyActivity healthyActivity = new HealthyActivity();
            healthyActivity.Enjoy();
            healthyActivity.FeelFresh();
            HealthyActivity smokingActivity = new SmokingActivity();
            smokingActivity.Enjoy();
            smokingActivity.FeelFresh();
            
            Unhandled exception. System.InvalidOperationException: Smoking doesn't make you feel fresh
```



#### Interface Segregation Principle

**No code should be forced to depend on methods it does not use**

#### Dependency Inversion Principle

**Depend upon abstractions. Do not depend on concrete classes.**

Våra high-level components ska inte vara beroende av våra low-level components, men bägge ska vara beroende av en abstraktion.

En high-level component är en klass med beteende definerat i form av andra, low-level components.

**High-level**

```
class PizzaStore
{
	MakePizza(Pizza pizza);
}
```

**Low-level**

```
public abstract class Pizza { 
	string Name;
}
```













https://www.youtube.com/watch?v=id_Ltb6EbvU&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=-ptMtJAdj40&t=417s&ab_channel=WebDevSimplified

https://www.udemy.com/course/design-patterns-csharp-dotnet

https://www.youtube.com/watch?v=70qA7XPAuNE&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=J6dWkStHEWk&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=-3UXq2krhyw











































