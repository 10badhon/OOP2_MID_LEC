using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   

        // Methos overloading ( just changing signature using same name )
        public void Test()    
        {
            Console.WriteLine("test with 0 parameters");
        }
        public void Test(int x) // number of parameter || 1 parameter   
        {
            Console.WriteLine("test with 1 int parameters");
        }
        public void Test(string x) // Type of parameter || 1 parameter but type is different
        {
            Console.WriteLine("test with 1 string parameter");
        }
        public void Test(int x, string y)
        {
            Console.WriteLine("test with 1 int and 1 string parameters");
        }
        public void Test(string y, int x) // Order of parameter  
        {
            Console.WriteLine("test with 1 string and 1 int parameters");
        }


        static void Main(string[] args)
        {
            // Polymorphism || Poly => many || morphic => froms of behaviors


            Program p = new Program();

            // Method Overloading ||  compile time polymorphism  
            p.Test();
            p.Test(100);
            p.Test("String");
            p.Test(10, "aiub");
            p.Test("aiub", 10);

            // Method Overriding concept in another class on this project go solution explorer and open Parent.cs

            Console.ReadKey();

        }
    }

}
