#### Decorator

Om vi börjar såhär:

```
public abstract class Beverage
    {
        protected string _description = "Unkown Beverage";

       public string GetDescription()
    {
        return _description;
    }
        public abstract double Cost();
    }
```

```
public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
```

```
Espresso espresso = new Espresso();
Console.WriteLine(espresso.Cost());
```

Så kommer vi tillslut att få en **Class explosion**



##### Design Principle

**The Open-Closed principle**. Classes should be open for extension, but closed for modification.
