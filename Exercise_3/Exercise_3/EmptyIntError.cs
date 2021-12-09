using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class EmptyIntError : UserError
    {
        public override string UEMessage()
        {
            return "You have left an numeric field empty. Pleas fill it and try again!";
        }
    }
}
