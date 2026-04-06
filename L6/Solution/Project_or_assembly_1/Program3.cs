using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_or_assembly_1
{
    class Program3
    {
        //Case : 3    Non-child class , same assembly 
        static void Main(string[] args)
        {
            // Program3 p = new Program3(); // this class have no member and thats not extend Program1 class 
            // so if you want to called program 1 method so you need Program 1 object 

            Program1 p = new Program1();
            p.test1();
           // p.test2();   // private 
           // p.test3();   // protected
           // p.test4();   // private protected // basically private means same project and protected means derived class
            p.test5();
            p.test6();

            Console.ReadKey();
        }
 
    }
}
