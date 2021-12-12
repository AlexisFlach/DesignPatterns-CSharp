using OpenClosed.Applicants.Solution.AccountProcessors;

namespace OpenClosed.Applicants.Solution.Entities
{
    public interface IApplicant
    {
        string Name { get; set; }
        IAccounts AccountProcessor {get; set;}
    }
}