namespace LiskovSubstitution.Salary.Setup
{
    public class Setup
    {
        public static void Run()
        {
            Manager accountingVP = new Manager();
            accountingVP.Name = "Tommy";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee();
            emp.Name = "Alex";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            System.Console.WriteLine($"{emp.Name}'s salary is ${emp.Salary}/hour");
        }
    }
    public class Manager : Employee
    {
        public void CalculatePerHourRate(int rate)
        {
            this.Salary = rate * 10;
        }

        public void GeneratePerformanceReview()
        {
            System.Console.WriteLine("I'm reviewing a report");
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Manager Manager { get; set; }
        public virtual void AssignManager(Manager manager)
        {
            this.Manager = manager;
        }
        public void CalculatePerHourRate(int rate)
        {
            this.Salary = rate * 8;
        }
    }

    public class CEO : Employee
    {
        public override void AssignManager(Manager manager)
        {
            throw new InvalidOperationException("The CEO doesn't have a manager");
        }

        public void FireSomeone() {
            
        }
    }
}