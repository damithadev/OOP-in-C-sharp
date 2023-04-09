using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();

            student1.sleep();  

            //typically get the parent class's result, but in this case parent class override by
            //child class, cuz it's display child class's result.

            Console.ReadKey();
        }
    }
}
