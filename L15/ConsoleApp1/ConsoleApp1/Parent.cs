using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
   // Method overriding => run time polymorphism
   // 3 keyoword : virtual , override , sealed 
   // Method hiding 

namespace ConsoleApp1
{
    class Parent
    {
        public virtual void Show() // ( virtual keyword ) means this method is overrideable
        {                          // this Parent class is holding Show method owenership so need permission for override using virtual keyword 
            Console.WriteLine("Show from parent class");
        }

        public void Test()  // this class don't give any permission for overriding || Method hiding concept 
        {
            Console.WriteLine("test from parent class");
        }
    }
    class Child : Parent
    {
        public override void Show() // ( override keyword ) using for reuse parent class show method 
        {
            Console.WriteLine("Show from Child class");
        }


        public new void Test() // erase new keyword so you will get a warning green wavelength 
                           // becasuse Compiler asking you are you intentionally hiding parent class test method so use new keyword 
        {
            Console.WriteLine("Test from Child class");
        }


    }

    class Child2 : Child
    {

        public sealed override void Show() // ( sealed keyword ) using for stop overriding for next child class
        {
            Console.WriteLine("Show from Child2 class");
        }

    } 
    sealed class Child3 : Child2  // using sealed keyword || now you can't inherit this class 
    {
        /*public  override void Show()     
        {
            Console.WriteLine("Show from Child3 class");     // Error || becuase this method is sealed in previoud class 
        }*/

        static void Main(string[] args)
        {

            // For overriding you must be need inheritance 

            Child3 c = new Child3();
            c.Show();


            Parent p = new Child(); 
            p.Show();  // show will be show child class show method || becuase parent give permission for override 
            p.Test();  // Test will be show parent class test method || because parent don't know that child have test method
                       // No permission method hiding 



            Console.ReadKey();
        }
    }
    // class Child4 : Child3   // Error beacuse Child3 class is sealed you can't inherit 
    
}
