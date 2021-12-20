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
    }
}
