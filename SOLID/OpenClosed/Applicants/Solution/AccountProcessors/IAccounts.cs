using OpenClosed.Applicants.Solution.Entities;
namespace OpenClosed.Applicants.Solution.AccountProcessors
{
    public interface IAccounts
    {
        Employee Create(IApplicant person);
    }
}