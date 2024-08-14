using StateExperiment.Shared.Models;

namespace StateExperiment.Shared.StateContainers
{
    public interface IPolicyStateContainer
    {
        Task<Policy> GetPolicy();
        Task SetFirstName(string firstName);
        Task SetLastName(string lastName);
    }
}