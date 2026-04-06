using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{    
        enum Gender    // user defined enum || work like data type
        {
            Male,Female,Other
        }
        enum Days
        {   
            Sunday, // take cursor on Sunday you will show default value of sunday    
            Monday=110, // you can also assign value like this next will be 111 
            Tuesday,
            Wednesday=210, // next will be 211 i mean thursday become 221 
            Thursday
        }

    class Program
    {
        Gender gender; // now Gender is data type and gender is varible 
        Days MeetingDay;



        static void Main(string[] args)
        {
            //Enumeration is an user defined data type
            //Enumeration is used to declare a set of named contacts under your namespace/class
            //Enum is like dropdown box you can only use selected values on Enum datatype


            Console.BackgroundColor = ConsoleColor.Cyan;   // ConsoleColor is an inbuild enum ... right click and go to definition 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("hello World");

            
            Program p = new Program();
            p.gender = Gender.Female;  // in gender varibale we can only assign Gender datatypes value 
            p.MeetingDay = Days.Tuesday;
            

            Console.WriteLine(p.gender);
            Console.WriteLine(p.MeetingDay);
            Console.WriteLine((int)p.MeetingDay); // converting into int that will show ta index number of Enum value
            

        
            foreach(int i in Enum.GetValues(typeof(Days))) // Calling and Printing Enum values 
            {
                Console.WriteLine( i+" : "+(Days)i) ; // (Days)i is type casting i is the value of enums and Days is datatype
                                                      // So for that all string will be shown 
            }

            
            Console.ReadKey();
        }
    }
}                   // Declare Enum on namespace 
                    // Declare a variable using Enum || because is name is user defines datatype 
                    // make an object then call Enum variable and assign the Enum value (p.gender=Gender.Male;) like this
