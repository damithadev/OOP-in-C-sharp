using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    internal class student : person        //inheritance
    {
        public override void sleep()            //override for child class
        {
            Console.WriteLine("This is child class");
        }
    }
}
