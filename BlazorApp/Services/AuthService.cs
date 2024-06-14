using BlazorApp.Responses;
using Blazored.LocalStorage;

namespace BlazorApp.Services
{
    public class AuthService
    {
        private readonly ILocalStorageService _localStorageService;

        public AuthService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async Task SignIn(AutenticarResponse response)
        {
           await _localStorageService.SetItemAsync("auth", response);
        }

        public async Task<AutenticarResponse?> GetData()
        {
            return await _localStorageService.GetItemAsync<AutenticarResponse>("auth");
        }

        public async Task SignOut()
        {
            await _localStorageService.RemoveItemAsync("auth");
        }
    }
}
