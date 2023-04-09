using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_1
{
    internal class person
    {
        public string name;
        public int age;



        /*
        -----------access mutator - short method---------
       
        public string name {  get; set; }
        public int age { get; set; }
        */




        /*
        -----------access mutator - long method----------

        //properties
        private string name;
        private int age;
        
        //access mutating
        public string Name
        { 
            get                    //read
            { 
                return name; 
            }
            set                    //write
            {
                name = value;
            }
        }

        public int Age
        {
            get                     //read
            {
                return age;
            }
            set                     //write
            {
                age = value;
            }
        }
        */


        /*
        //create read only property using long access mutator
        public int Age
        {
            get                     //read
            {
                return age;
            }
            private set                     //write disabled
            {
                
            }
        }

        */


        //methods
        public void eating()
        {
            Console.WriteLine("I'm eating");

        }

        public void sleeping () 
        {
            Console.WriteLine("I'm sleeping");
        }


    }
}
