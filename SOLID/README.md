# SOLID

#### Single Responsibility Principle

**Every object in your system should have a single responsibility, and all the object's services should be focused on carrying out that single responsibility**.

Man brukar säga att en klass endast ska en anledning till att ändras.

Vi kan sätta ett likhets tecken mellan ansvarsområde och "anledning att till att ändras".

```c#
	public  class Car
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
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName) => 				Console.WriteLine($"Please enter a valid {fieldName}");
    }
}
```

#### Open/Closed Principle

**Classes should be open for extension but closed for modification**.

Se följande PizzaStore klass:

```
  class PizzaStore
    {
        private PizzaOven _oven;
        public PizzaStore()
        {
            _oven = new PizzaOven();
        }

        public void MakePizza(PizzaType type)
        {
            PizzaIngredients pizzaIngredients;
            switch (type)
            {
                case PizzaType.American:
                    pizzaIngredients = new PizzaIngredients("Tripple 						cheese", "Bacon");
                    _oven.Bake(pizzaIngredients);
                    break;
                case PizzaType.Italian:
                    pizzaIngredients = new PizzaIngredients("Tomato Sauce", 					"Cheese");
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
    }
```

**Övning**

För endast PizzaTypes: Vegeterian, Italian och American funkar den perfekt, men vad händer om vi vill lägga till fler pizzasorter? Då måste vi in och modifiera koden, ex. lägga till ett nytt switch-case. Klassen är med andra ord inte stängd för modifiering. Vad vi vill är att den ska vara öppen för extensions, alltså att vi ska kunna lägga till en pizzatype, men utan öppna upp klassen.

#### Liskow Substititution Principle

**Subtypes must be substitutable for their base types**

Denna princip handlar om väldesignada arv. När vi ärver från en basklass, måste vi kunna byta ut våra subklasser mot den basklassen utan problem.

Det handlar mer om beteende, än attribut.

```
class HealthyActivity
{
	public virtual void Enjoy() {};
	public void FeelFresh() {
	...
	};
}
```

```
class SmokingACigarette : HealthyActivity
{
	public overide void Enjoy()
	{
		ConsoleWrite("Enjoying my cigarette");
	}
	public void SpendMoney() 
	{
	...
	}
	public void IncreaseBadHealth()
    {
    ...
    }
	
}
```

```
HealthyActivity smoking = new SmokingACigarette();
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













































