using OpenClosed.Applicants.Setup.Entities;
namespace OpenClosed.Applicants.Setup
{
    public class Accounts
    {
        public Employee Create(Person person)
        {
            Employee emp = new Employee();
            emp.Name = person.Name;
            emp.Email = $"{person.Name}@company.com";
           
        
        switch(person.EmployeeType)
        {
            case EmployeeType.Staff:
                break;
            case EmployeeType.Manager:
                emp.IsManager = true;
                break;
            case EmployeeType.Executive:
                emp.IsManager = true;
                emp.IsExecutive = true;
                break;
            default:
                break;
        }
        return emp;
    }
}
}