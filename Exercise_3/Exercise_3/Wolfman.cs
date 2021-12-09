using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, int packSize) : base(name, weight, age, packSize)
        {
        }

        public void Talk()
        {
            Console.WriteLine("aaawwwiiiihhhheeeejjj");
        }
    }
}
