using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.age = 10;

            student student1 = new student();
            student1.age = 20;                 
            
            //if you creating a object from student class, then u can access person class properties too,
            //cuz person class is the parent class and student class is the child class.
            //(child class can access parent class's properties)


            Console.WriteLine(student1.age);
            Console.ReadKey();
        }
    }
}
