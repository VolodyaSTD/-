using System;
using System.Collections.Generic;
using System.Text;

namespace МенеджнрПаролей
{
    public static class PasswordGenerator
    {
        private const string Lower = "abcdefghijklmnopqrstuvwxyz";
        private const string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        private const string Symbols = "!@#$%^&*?";

        private static readonly Random random = new Random();

        public static string Generate(int length = 12)
        {
            string allChars = Lower + Upper + Digits + Symbols;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(allChars.Length);
                sb.Append(allChars[index]);
            }

            return sb.ToString();
        }
    }
}