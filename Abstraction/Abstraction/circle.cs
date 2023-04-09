using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class circle : shape           //inheritance
    {
        //implement values/equations to abstract method
        public override void calculateArea()               //use override keyword
        {
            int r = 5;
            double area = Math.PI * r * r;
            Console.WriteLine("Area is: " +area);
        }
    }
}
