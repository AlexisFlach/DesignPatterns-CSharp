using OpenClosed.Applicants.Solution.AccountProcessors;

namespace OpenClosed.Applicants.Solution.Entities
{
       public class Person : IApplicant
    {
        public string Name { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}