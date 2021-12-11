using static System.Console;

interface IFastFoodTasks
{
    void MakePizza();
    void MakeFries();
    void MakeColdCoffee();
    void MakeEspresso();
}

class FoodEmployee : IFastFoodTasks
{
    public void MakeColdCoffee()
    {
        throw new NotImplementedException();
    }

    public void MakeEspresso()
    {
        throw new NotImplementedException();
    }

    public void MakeFries()
    {
        WriteLine("Making Fries");
    }

    public void MakePizza()
    {
        WriteLine("Making Pizza");
    }
}

class BeverageEmployee : IFastFoodTasks
{
    public void MakeColdCoffee()
    {
        throw new NotImplementedException();
    }

    public void MakeEspresso()
    {
        throw new NotImplementedException();
    }

    public void MakeFries()
    {
        throw new NotImplementedException();
    }

    public void MakePizza()
    {
        throw new NotImplementedException();
    }
}