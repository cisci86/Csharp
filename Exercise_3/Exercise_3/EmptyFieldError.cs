using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class EmptyFieldError : UserError
    {
        public override string UEMessage()
        {
            return "You have left a mandatory field empty. Pleas fill it and try again!";
        }
    }
}
