using Blazored.SessionStorage;
using StateExperiment.Shared.Models;

namespace StateExperiment.Shared.StateContainers
{
    public class PolicyStateContainer : IPolicyStateContainer
    {
        private readonly ISessionStorageService _sessionStorageService;
        private readonly string key = "policy";

        public PolicyStateContainer(ISessionStorageService sessionStorage)
        {
            _sessionStorageService = sessionStorage;
        }

        public async Task SetFirstName(string firstName)
        {
            var policy = await GetPolicy();
            policy.FirstName = firstName;
            await SetPolicy(policy);
        }

        public async Task SetLastName(string lastName)
        {
            var policy = await GetPolicy();
            policy.LastName = lastName;
            await SetPolicy(policy);
        }

        public async Task<Policy> GetPolicy()
        {
            var result = await _sessionStorageService.GetItemAsync<Policy>(key);
            return result ?? new Policy();
        }

        private async Task SetPolicy(Policy policy)
        {
            await _sessionStorageService.SetItemAsync(key, policy);

        }
    }
}
