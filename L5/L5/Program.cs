using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
     class Program
    {
        static int pass_mark;   // static member / class member 

        int obatained_mark;   // Non-Static member / instance member 

        static void Main(string[] args)
        {

            Program p1 = new Program();

            Program.pass_mark = 200;  

            Console.WriteLine(Program.pass_mark);

            p1.obatained_mark = 100;

            /* Instance Member                    Static Member         

     | Belongs to object                |       Belongs to class      |
     | Needs object                     |       No object needed      |
     | Separate copy for each object    |       Only one shared copy  |
     | Access via object                |       Access via class name |*/







            // condition ? true : false 
            int y = 10;

            Console.WriteLine( y == 55 ? "yo" : "no" ) ;

            int age = 50;

            string result = age < 50 ? "True" : "False";
            Console.WriteLine(result);
        }
    }
}
