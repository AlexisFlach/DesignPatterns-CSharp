using OpenClosed.Applicants.Setup.Entities;

namespace OpenClosed.Applicants.Setup
{
    public class Setup
    {
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
    }

}