using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method overloading
            person person1 = new person();
            person1.sleep("king");


            Console.ReadKey();
        }
    }
}
