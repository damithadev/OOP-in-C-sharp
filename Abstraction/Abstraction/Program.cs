using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle1 = new circle();      //creating obj for child class

            circle1.calculateArea();

            Console.ReadKey();
        }
    }
}
