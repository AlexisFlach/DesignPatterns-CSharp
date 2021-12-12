using OpenClosed.Applicants.Setup;

namespace OpenClosed.Applicants.Setup.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public EmployeeType EmployeeType { get; set; } = EmployeeType.Staff;
    }
}