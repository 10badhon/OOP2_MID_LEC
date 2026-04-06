using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Object a = 10;                   // Object class is the base class of all types in C#
                                             // Object is the parent class of all data type 

            Object b = "badhon"; //In C#, every class automatically inherits from the Object class (even if you don’t write it).
                                 // The Object class is defined in the Microsoft.NET base library and is the root of all types.

            Object c = true; 

            Object d = 1.1;

            // uint e = -10;               // error || uint means unsigned integer => only allow (+)positive numbers 
            
            uint f = 10; 


            

        }

        class Dog  // Type 
        {          // Type is a blueprint 
          
            static void Main(string[] args)
            {
                Dog rover = new Dog(); // Object 
                                       // Object is Real instance
            }
        }
}
}
