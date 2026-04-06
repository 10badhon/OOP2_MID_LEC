using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_or_assembly_1
{    
            //case 2 : Derived class same assembly or project 
    class Program2 : Program1    // inheritance 
    {

        static void Main(string[] args) {
            Program2 p = new Program2();
            p.test1();
        //  p.test2();   // private 
            p.test3();
            p.test4();
            p.test5();
            p.test6();

            Console.ReadKey();
        }
    }
}
// in this project there have multiple Main method so you need to declare which Main method you want to execute 
// right click on project name then click on properties and change startup object 
