using System;
using System.Security.Cryptography;
using System.Text;

namespace BusStationApp.BLL.Security
{
    public static class PasswordHasher
    {
        public static string Hash(string plainText)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
