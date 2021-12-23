using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    static class Utility
    {
        public static int VerifyIntInput(string input)
        {
            if(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return -1;
            return int.TryParse(input, out int outPut) ? outPut : -1;
        }

        internal static string VerifyStringInput(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return null!;
            return input;
        }
        internal static bool ChechRegNumber(string regNumber)
        {
            bool correct = false;
            if(regNumber.Length != 6)
                return false;
            char[] okChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for(int i = 0; i < 3; i++)
            {
                if(regNumber[i].Equals(okChars))
                    correct = true;
                else
                {
                    correct = false;
                    break;
                }
            }
            for (int i = 3; i < regNumber.Length; i++)
            {
                if (int.TryParse(regNumber[i].ToString(), out int num))
                    correct = true;
                else
                {
                    correct = false;
                    break;
                }
            }
            return correct;

        }
    }
}
