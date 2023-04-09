using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    internal class person
    {
        public virtual void sleep()                  //virtual for parent class
        {
            Console.WriteLine("This is parent class");
        }
    }
}
