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

Filtrera produkter:

```
    public enum Color
    {
        Red, Green, Blue
    }
```

```
    public enum Size
    {
        Small, Medium, Large
    }
```

```c#
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
```

```c#
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> 			products, Size size)
        {
            List<Product> filterProducts = new() { };
            foreach (Product p in products)
            {
                if (p.Size == size)
                {
                    filterProducts.Add(p);
                }
            }
            return filterProducts;
        }
```

Om vi vill lägga till en funktion för att även filtrera färg, måste vi gå in i ProductFilter och modifiera detta.

```c#
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> 			products, Size size)
        {
            List<Product> filterProducts = new() { };
            foreach (Product p in products)
            {
                if (p.Size == size)
                {
                    filterProducts.Add(p);
                }
            }
            return filterProducts;
        }
        public static IEnumerable<Product FilterByColor(IEnumerable<Product> 			products, Color color)
        {
            List<Product> filterProducts = new() { };
            foreach (Product p in products)
            {
                if (p.Color == color)
                {
                    filterProducts.Add(p);
                }
            }
            return filterProducts;
        }
    }
```

**The only constant is change**. Nu får vi till oss att ProductFilter även ska kunna filtrera färg OCH storlekt på samma gång.

Detta bryter återigen **Open/Closed principle**. Vi vill kunna extenda funkltionaliteten genom att kunna utföra denna filtrering, men vi vill inte gå in och modifiera detta i vår ProductFilter-klass.















































