using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{                           // as & is operator 
    class A
    {
    }
    class B
    {
    }
    class C
    {    
        public static void Test(object o)
        {
            // A a = (A)o; // first time will ok 2nd and for 3rd time will show error because 2nd one is B object and 3rd is string 4th also 
            if (o is A)
            {
                A a = (A)o;
                Console.WriteLine("o is class A type");
            }
            else if (o is B)
            {
                B b = (B)o;
                Console.WriteLine("o is Class B type");
            }
            else if ( o is string)
            {
                Console.WriteLine(" o is string type ");
            }
            else
            {
                Console.WriteLine(" not matching ");
            }
        }

        static void Main(string[] args)
        {
            A ob1 = new A();
            B ob2 = new B();

            Test(ob1);
            Test(ob2);
            Test("anfinafn");
            Test(100);


            object a = "arieanfni";
            string s = a as string;   // as operator using for safe casting 
            Console.WriteLine(s);
            Console.WriteLine(s == null);



            object obj = 100;
            string str = obj as string;  // can't convert int to string 
            
            Console.WriteLine(str);   // null nothing 
            Console.WriteLine(str == null); // false 

            Console.ReadKey();
        }
    }

    //   as =>   as never throws exception                              is => Returns true or false
    //           Failed cast → null                                           Does not throw exceptions
    //           Printing null → blank line







}    // Before run you need to select Main method which on you want to execute so first go on solution explorer right click on project (L2)
     //      L2 --> Properties --> startup object