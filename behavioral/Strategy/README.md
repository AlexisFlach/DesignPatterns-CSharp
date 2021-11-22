#### Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one and makes them interchangeable. Strategy lets the algorithm vary independendently from clients that use it.

###### Vad vi gör

Vi ska skapa en ankdammssimulators-spel. Spelet kommer att innehålla en många olika ank-arter som kommer att kunna simma och göra kvackiga ljud.

Vi börjar med att skapa en Duck Superclass vilka övriga subclasses kommer att ärva ifrån.

```
public abstract class Duck 
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quack!!");
        }

        public void Swim()
        {
            Console.WriteLine("Swim Swim!!");
        }

        public abstract void Display();
    }
}
```

```

    public class MallardDuck : Duck
    {
            public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}
```

```
public class RubberDuck : Duck
    {   
        public void Squeak()
        {
            Console.WriteLine("Squeak!!");
        }

        public override void Quack()
        {
            Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck");
        }
    }
}
```

Allt gott så långt, men **The only constant is change** så nu får vi till oss att ankorna även ska kunna flyga.

```
        public void Fly()
        {
            Console.WriteLine("Flyyyyiiiing!!")
        }
```

Vad vi trodde skulle kunna lösas med hjälp av **inheritance** gav oss istället stora problem. Det konkreta problemet är att vi har Gummiankor som flyger runt i vårt spel.

<img src="https://media.giphy.com/media/ghuvaCOI6GOoTX0RmH/giphy.gif" alt="Alt Text" style="zoom:50%;" />

Vad gör vi?

Overridare fly() i RubberDuck till att inte kunna flyga? Men vad händer om vi lägger till en trä-anka som varken kan flyga eller låta?

Vi kan konstatera att vårt kommande arbete kommer att bli väldigt tråkigt då vi måste overrida metoder och ha oss.

Låt oss formulera ett mål med vår design:

Att varje gång vi behöver ändra eller lägga till något så ska det gå smidigt till.

Till detta kan vi använda oss av en Design Princip som säger:

**Identify the aspects of your application that vary and separete them from what stays the same**

Ta delarna som varierar och kapsla in dessa, så att vi vid senare tillfälle kan extenda eller modifiera dessa utan att delarna som är konstanta påverkas.

**fly()** och **quack()** är delar som varierar mellan våra ankor, så vi separerar dessa **behaviors** från **Duck**.

Här kommer vi in på nästa Design princip:

**Program to an interface, not an implementation**

Vi vill vara redo för förändring. Säg att vi har två flygbeteenden; FlyWithWings och FlyNoWay.

Att programmera till en implementation:

```
Dog dog = new Dog();
dogh.bark();
```

Att programmera till en interface/supertype

```
Animal animal = new Dog();
animal.makeSound();
```

Låt oss analysera den färdiga koden och börja bakifrån:

```
static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
        }
```

Här kommer vi in på nästa Design Princip:

**Favor composition over inheritance**

eller

HAS-A can be better than a IS-a.

Varje Duck har ett FlyBehavior till vilken den **delegerar** flygandet till. När vi använder två klasser såhär kallas det för **composition**. Istället för att ärva bettende så blir Ducks composed med rätt beteende.







