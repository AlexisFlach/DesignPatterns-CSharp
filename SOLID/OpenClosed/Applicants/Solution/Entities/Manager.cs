using OpenClosed.Applicants.Solution.AccountProcessors;
using OpenClosed.Applicants.Solution.Entities;

namespace OpenClosed.Applicants.Solution
{
    public class Manager : IApplicant
    {
        public string Name { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}