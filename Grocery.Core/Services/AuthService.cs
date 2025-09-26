using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientService _clientService;
        public AuthService(IClientService clientService)
        {
            _clientService = clientService;
        }
        public Client? Login(string email, string password)
        {
            Client? client = _clientService.Get(email);
            if (client == null) return null;
            if (PasswordHelper.VerifyPassword(password, client.Password)) return client;
            return null;
        }

        public Client? Register(string email, string password, string name)
        {
            // Check if all parameters are filled and validate the parameters
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name)) return null;
            
            // Check if the email is already in use
            Client? existingClient = _clientService.Get(email);
            if (existingClient != null) return null;
            
            // Verify if email is valid with the email helper
            if (!EmailHelper.ValidateEmail(email)) return null;
            // EmailHelper emailHelper = new EmailHelper();
            // if (!emailHelper.ValidateEmail(email)) return null;
            
            // Verify the password through the password helper
            if (!PasswordHelper.ValidatePasswordStrength(password)) return null;
            
            Client newClient = _clientService.Create(email, PasswordHelper.HashPassword(password), name);

            return newClient;
        }
    }
}
