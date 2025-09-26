using System.Security.Cryptography;
using System.Text;

namespace Grocery.Core.Helpers
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, 100000, HashAlgorithmName.SHA256, 32);
            return Convert.ToBase64String(salt) + "." + Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            var parts = storedHash.Split('.');
            if (parts.Length != 2) return false;

            var salt = Convert.FromBase64String(parts[0]);
            var hash = Convert.FromBase64String(parts[1]);
            var inputHash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, 100000, HashAlgorithmName.SHA256, 32);

            return CryptographicOperations.FixedTimeEquals(inputHash, hash);
        }

        public static bool ValidatePasswordStrength(string password)
        {
            // Length checks
            if (password.Length < 8 || password.Length > 255) 
                return false;
            
            // Checks voor een getal
            if (!password.Any(char.IsDigit)) 
                return false;

            // Check of er een hoge en lage letter in zit
            if (!password.Any(char.IsLower) || !password.Any(char.IsUpper))
                return false;

            // Check of er een speciaal teken in zit
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            // Als alles gepasseerd is return true
            return true;

        }
    }
}
