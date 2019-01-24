using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_System
{
    public static class CardsValidation
    {
        private static readonly int[] results = new[] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        private static readonly Random random = new Random();

        public static bool LuhnCheck(int[] digits)
        {
            if (digits == null)
            {
                throw new ArgumentNullException("digits");
            }

            return CheckDigits(digits);
        }

        private static bool CheckDigits(int[] digits)
        {
            for (int i = digits.Length % 2; i < digits.Length; i += 2)
            {
                digits[i] = results[digits[i]];
            }

            return digits.Sum() % 10 == 0;
        }

        public static bool LuhnCheck(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
            {
                throw new ArgumentNullException("cardNumber");
            }

            int[] digits = cardNumber.Select(c => c - '0').ToArray();

            if (digits.Sum() == 0)
            {
                return false;
            }

            return CheckDigits(digits);
        }
    }
}
    

