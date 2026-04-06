using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_or_assembly_1
{          
              // Case 1 : within the class , no restrictions ( open access modifier slide )
    public class Program1 // using public because by deafult is private || go on program 4 
    { 
        public void test1()
        {
            Console.WriteLine("Public");
        }
        private void test2()
        {
            Console.WriteLine("Private");
        }
        protected void test3()
        {
            Console.WriteLine("Protected");
        }
        private protected void test4()
        {
            Console.WriteLine("Private Protected");
        }
        internal void test5()
        {
            Console.WriteLine("Internal");
        }
        protected internal void test6()
        {
            Console.WriteLine("Protected internal");
        }

        static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.test1();
            p.test2();
            p.test3();
            p.test4();
            p.test5();
            p.test6();

            Console.ReadKey();
        }
    }
}
// internal works only in same project/assembly
// private protected   // private means in this project // protected means only derived class
// protected internal  // works in same project & other project also if that class derived first project