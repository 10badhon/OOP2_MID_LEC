using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
     class Program
    {

        // const keyword
                            
        const int vat = 20;   // mustbe need assign value on declare time 
                              // const can declare in class or local scope 
                              //  ✅ const is implicitly static in C#
                            

        // vat = 10  error because this variable is const can't be changed 

        const string version = "v1.0.0";



        // readonly keyword 

        readonly int a = 5;
        readonly int yoyo;   // readonly keyword can declare without assign any value 
                             // only can declare in class not Main method || class level keyword 
                             // you can assign value on declare time or using constructor 


        public Program(int value) // using constructor for intialize value on yoyo variable 
        {
            this.yoyo = value;
        }


        static void Main(string[] args)
        {

            Program v = new Program(50); // intializing value in yoyo by constructor 


            // Console.WriteLine(v.vat);    // Error because const keyword dont need any object reference because 
            //       ✅ const is implicitly static in C#


            Console.WriteLine(Program.vat);
            Console.WriteLine(vat);

            

            Console.WriteLine(v.yoyo);  // for print yo yo you must need object because its not static 




            const int b = 6; // const can declare in local scope 

           // readonly int c=7; // error readonly only can declare in class scope 


            
           
            
            /*Difference in Simple Words

                    readonly → value can be assigned at declaration or inside constructor

                    const → value must be assigned at declaration only
                    readonly → for class fields

                    const → can be used inside methods*/


           /*If variable is:

                    Inside method → use const

                    Inside class (field) → use readonly*/







    }
    }
}
