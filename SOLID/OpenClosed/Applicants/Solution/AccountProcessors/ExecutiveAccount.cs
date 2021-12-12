using OpenClosed.Applicants.Solution.Entities;

namespace OpenClosed.Applicants.Solution.AccountProcessors
{
    public class ExecutiveAccount : IAccounts
    {
         public Employee Create(IApplicant person)
        {
            Employee emp = new Employee();
            emp.Name = person.Name;
            emp.Email = $"{person.Name}@company.com";
            emp.IsExecutive = true;

            return emp;
        }
    }
}