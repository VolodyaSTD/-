using System;
using System.Collections.Generic;
using System.Text;

namespace МенеджнрПаролей
{
    public static class PasswordStrength
    {
        public static int Evaluate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return 0;
            int score = 0;

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;

            bool hasLower = false, hasUpper = false, hasDigit = false, hasSymbol = false;
            foreach(char c in password)
            {
                if (char.IsLower(c)) hasLower = true;
                else if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSymbol = true;
            }
            
            if (hasLower) score++;
            if (hasUpper) score++;
            if (hasDigit) score++;
            if (hasSymbol) score++;

            return score * 100 / 6;
        }

        public static string GetLable(int score)
        {
            if (score < 40) return "Слабый";
            if (score < 75) return "Средний";
            return "Надежный";
        }
    }
}