using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public void Talk()
        {
            Console.WriteLine("aaawwwiiiihhhheeeejjj");
        }
    }
}
