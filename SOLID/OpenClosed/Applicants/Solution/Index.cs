using OpenClosed.Applicants.Solution.Entities;

namespace OpenClosed.Applicants.Solution
{
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

}