using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object 1
            person person1 = new person();

            //creating object 2
            person person2 = new person();

            //Accessing properties of the class
            person1.name = "Damitha";
            person1.age = 20;

            person2.name = "Jayatharaka";
            person2.age = 21;


            //printing properties of the class
            Console.WriteLine("Name is: " +person1.name);
            Console.WriteLine("Age is: " + person1.age);

            //Accessing methods of the class
            person2.eating();
            person2.sleeping();


            Console.ReadKey();  
        }
    }
}
