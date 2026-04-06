using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace L2
{   
     class Parent
    {
       
    }
     class Child : Parent // inherit parent class
    {
        
    }
     class Child2 : Child 
    {
        static void Main(string[] args)
        {

            // neumeric to neumeric conversion 

            int x = 100;
            double d = x; // int to double ( implicit convertion ) because going smaller value on bigger variable 
            int f = (int)d;  // Error need type casting (explicit conversion ) because 64 bit going on 32 bit 


            // Refernece to Reference conversion 

            Parent p = new Child();     // child to parent , implicit conversion
            Child c = (Child)p;         // parent to child , need casting (explicit converion) 

            //Child2 c1 = (Child2)p;    // it will throw an exception run time error because P is holding child instance and we are going to cast by child2 || Error |
                                        // Need is operator for verify which instance is holding P  


            if(p is Child)      // is operator ( more details in solution explorer another class (A.cs)
            {
                Console.WriteLine("P is carries child instance");
                Child c2 = (Child)p;
            }
            else if(p  is Child2)
            {
                Console.WriteLine("p is carries Child2 instance");
                Child2 c2 = (Child2)p;
            }
            // No error 





            // value to int conversion using parsing method 

            string valueage = "-22";

            int age = int.Parse(valueage);                       // parse method

            string s1 = age.ToString();



            // var keyword 

            // var ageeee; || error because var can't define which type of variable is this 

            var age1 = 22; // compiler can define the type of this variable by the value 

            var num0 = 1.2f;      // The type is decided at compile time

            var num1 = 0.1111; // double 

            var name = "badhon";

            var letter = 'b';

            Console.WriteLine(age1);
            Console.WriteLine(num0);
            Console.WriteLine(num1);
            Console.WriteLine(name);
            Console.WriteLine(letter);

            // dynamic keyword 
            // dynamic is same as var keyword ...      difference is var is compile time || dynamic is run time 
            dynamic aa = 10;
            dynamic bb = "badhon";
            dynamic cc;
           // var dd; // error var can't define which type of variable is this 

            Console.WriteLine(aa);
            Console.WriteLine(bb);
            


            Console.ReadKey();
        }
    }

}
