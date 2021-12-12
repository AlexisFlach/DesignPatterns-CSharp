namespace OpenClosed.Applicants.Solution.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
    }
}