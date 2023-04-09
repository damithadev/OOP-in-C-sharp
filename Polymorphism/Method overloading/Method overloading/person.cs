using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class person
    {
        public string name;
        public int age;

        //method overloading
        public void sleep(int roomNo) 
        {
            Console.WriteLine("Room No: " +roomNo);
        }

        public void sleep(string bedSize) 
        {
            Console.WriteLine("Bed Size: " +bedSize);
        }
    }
}
