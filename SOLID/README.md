# SOLID

#### Single Responsibility Principle

**Every object in your system should have a single responsibility, and all the object's services should be focused on carrying out that single responsibility**.

Man brukar säga att en klass endast ska en anledning till att ändras.

Vi kan sätta ett likhets tecken mellan ansvarsområde och "anledning att till att ändras".

```c#
	public class Car
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

Efter ha använt denna teknik kan vi ha en design som ser ut såhär:

```
    public  class Car
    {
        public void Start() {
            System.Console.WriteLine("The car is starting!!");
        }
        public void Stop() {
            System.Console.WriteLine("The car is stopping!!");
        }
        public int GetOil() {
           return -1;
        }
    }
```

```
	public class Driver {
        public void Drive() => Console.WriteLine("I am driving!!");
    }
```

```
    public class CarWash {
        public void Wash(Car car) => Console.WriteLine("I am washing the" + car);
    }
```

```
	public class Mechanic {
        public void ChangeTires(Car car, Tire tire) {
            Console.WriteLine( $"I am changing the {tire} tires on the car {car}");
        }
    }
```

#### Open/Closed Principle

**Classes should be open for extension but closed for modification**

#### Liskow Substititution Principle

**Subtypes must be substitutable for their base types**

Denna princip handlar om väldesignada arv. När vi ärver från en basklass, måste vi kunna byta ut våra subklasser mot den basklassen utan problem.

























https://www.youtube.com/watch?v=id_Ltb6EbvU&ab_channel=CodeRadiance

https://www.youtube.com/watch?v=-ptMtJAdj40&t=417s&ab_channel=WebDevSimplified

https://www.udemy.com/course/design-patterns-csharp-dotnet

https://www.youtube.com/watch?v=70qA7XPAuNE&ab_channel=CodeRadiance















































