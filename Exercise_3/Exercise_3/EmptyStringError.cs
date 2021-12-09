using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class EmptyStringError : UserError
    {
        public override string UEMessage()
        {
            return "You have left a mandatory text field empty! Fill it and try again!";
        }
    }
}
