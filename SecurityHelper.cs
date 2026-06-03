using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Security.Cryptography;

namespace МенеджнрПаролей
{
    public static class SecurityHelper
    {
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(password + salt);
                byte[] hash = sha.ComputeHash(data);   
                return Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword (string password, string salt, string expectedHash)
        {
            return  HashPassword(password, salt) == expectedHash;
        }

        public static string Encrypt(string text, string key)
        {
            byte[] encrypted = Xor(Encoding.UTF8.GetBytes(text), key);
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string cipherBase64, string key)
        {
            byte[] cipher = Convert.FromBase64String(cipherBase64);
            byte[] decrypted = Xor(cipher, key);
            return Encoding.UTF8.GetString(decrypted);
        }

        private static byte[] Xor(byte[] data,  string key)
        {
            byte[] KeyBytes = Encoding.UTF8.GetBytes(key);
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ KeyBytes[i % KeyBytes.Length]);
            }
            return result;
        }
    }
}