# SOLID

SOLID är en samling designprinciper som används i OOP. Principerna bakom SOLID togs fram av Robert C. Martin år 2000 och tar fasta på det faktum software förändras, och därmed bli mer komplext. 

Utan goda designprinciper kommer system få svårt att hantera dessa förändringar. Det stora målet med SOLID är att minska beroenden, så att när en del av applikationen förändras så påverkar inte det övrig kod. Övriga nyttor är att designen blir enklare att underhålla och förlänga.

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

En viktig sak att tänka på när det gäller SRP är att när vi talar om en anledning att ändras, så pratar vi inte om antalet metoder i en klass, utan antal ansvarsområden.

Vi uppnår detta genom att använda små klasser med begränsade mål. Varje klass är alltså nöjd med att *endast* utföra en sak, men att utföra den saken väldigt bra.

#### Open/Closed Principle

**Classes should be open for extension but closed for modification**.

En entitet ska tillåta att dess *behavior* förändras utan att modifiera dess source code.

Vi uppnår detta detta genom att undvika att vara beroende av en specifik implementation, och istället använda oss av abstrakta klasser eller interfaces.

Exempel:

Inloggningssystem för en skola där vi har elev, lärare och personal.

```
class LoginService
{
    public void Login(user)
    {
        if(user == "elev) {
            // Kolla elevens credentials
        } else if(user == "lärare")
        {
            // kolla lärarens credentials
        }
        ...osv
    }
}

```

Om vi även skulle lägga till inloggningsmöjligheter för extern personal hade vi behövt gå in och modifiera koden.

Som sagt så uppnår vi Open/Closed genom att istället använda oss av abstraktioner.

´´´
interface ILogin
{
    void CheckCredentials(ILoginable user);
}
´´´

```
class ElevAuthentication : ILogin
{
    // Kolla elevens credentials
}
´´´

```
class LärareAuthentication : ILogin
{
    // Kolla lärarens credentials
}
´´´

#### Liskow Substititution Principle

**Subtypes must be substitutable for their base types**

och/eller

**Objects in program should be replaceable with instances of their subtypes without altering the correctness of the program**

och/eller

**Liskov's Substitution Principle says that each class that inherits from another can be used as its parent without having to know the differences between them.**

Denna princip handlar om väldesignada arv. När vi ärver från en basklass, måste vi kunna byta ut våra subklasser mot den basklassen utan problem.

Det handlar mer om beteende, än attribut.

Vi uppnår detta genom att se till så att beteendet i vår sub-class respekterar kontraktet som har givits och etablerats från the super-class. 

Alltså om du vill vara som mig, så måste du bete dig som mig.

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

och/eller

**A client should only know the methods they are going to use and not those that they are not going to use.**

Vi uppnår detta genom att definera interfaces kontrakt baserat på clients som använder dem, och inte på de implementationer som vi skulle kunna ha.


#### Dependency Inversion Principle

**Depend upon abstractions. Do not depend on concrete classes.**

Våra high-level components ska inte vara beroende av våra low-level components, men bägge ska vara beroende av en abstraktion.

En high-level component är en klass med beteende definerat i form av andra, low-level components.

Vi uppnår detta genom att injicera dependencies i våra constructors och att lita till interfaces istället för konkreta implementationer.

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

#### Övningar

###### Single-Responsibility Principle

1. Cars

[SRP](https://github.com/AlexisFlach/DesignPatterns-CSharp/tree/main/SOLID/singleresponsibility/cars/setup) - CARS

Ändra klassen och bryt ned till klasser och metoder som följer SRP.

2. UserInputs

[SRP](https://github.com/AlexisFlach/DesignPatterns-CSharp/tree/main/SOLID/singleresponsibility/userinputs/setup) - User inputs

Ändra klassen och bryt ned till klasser och metoder som följer SRP.

###### Open/Closed Principle

1. CardMaker

Här har vi en applikation som ska bakar pizzor Baserat på PizzaType så bakas en viss typ av pizza.
Lägger vi till en ny PizzaType så behöver vi gå in i metoden och modifiera. 

```
   public void MakePizza(PizzaType type)
        {
            PizzaIngredients pizzaIngredients;
            switch (type)
            {
                case PizzaType.American:
                    pizzaIngredients = new PizzaIngredients("Tripple cheese", "Bacon");
                    _oven.Bake(pizzaIngredients);
                    pizzaIngredients.PrintIngredients();
                    break;
                case PizzaType.Italian:
                    pizzaIngredients = new PizzaIngredients("Tomato Sauce", "Cheese");
                    _oven.Bake(pizzaIngredients);
                    break;
                case PizzaType.Vegetarian:
                    pizzaIngredients = new PizzaIngredients("Sallad");
                    _oven.Bake(pizzaIngredients);
                    break;
                default:
                    break;

            }
        }
```

Tillämpa Open/closed så att vi kan lägga till en typ av Pizza utan att modifiera koden.

###### Liskov Substitution Principle

1. 

[Liskow Substitution](https://github.com/AlexisFlach/DesignPatterns-CSharp/tree/main/SOLID/LiskovSubstitution/Cars/Setup) - Liskov  Substitution

1. Ändra programmet så att det följer Liskov Substitution principle

###### Interface Segregation Principle

[Interface Segregation](https://github.com/AlexisFlach/DesignPatterns-CSharp/tree/main/SOLID/InterfaceSegregation/Setup/NoISP) - Interface Segregation

1. Ändra programmet så att det följer Interface segregation principle


###### Dependency Inversion

[Dependency Inversion](https://github.com/AlexisFlach/DesignPatterns-CSharp/tree/main/SOLID/DependencyInversion/CalculatorApp) - Dependency Inversion

1. Lägg till yterliggare funktioner som division och multiplikation. Fundera på vilken annan princip vi följer i detta exempel.


Länkar:

https://www.youtube.com/watch?v=id_Ltb6EbvU&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=-ptMtJAdj40&t=417s&ab_channel=WebDevSimplified

https://www.udemy.com/course/design-patterns-csharp-dotnet

https://www.youtube.com/watch?v=70qA7XPAuNE&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=J6dWkStHEWk&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=-3UXq2krhyw











































