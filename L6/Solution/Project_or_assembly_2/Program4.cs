using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_or_assembly_1;  // adding reference 

namespace Project_or_assembly_2 
{     //  Case 4 :  child class , different assembly or project 
    class Program4 : Program1
    {     // for inherit other project classes you need to add reference .. right click on
          //                                                  project --> add --> reference --> project ( select which one you want to add )
          //  then add refernce of that project by using keyword on top 
          //  make sure inherit parent class must be Public because 
                                  // in java default is package private
                                  // in c# deafult is Private  || most restricted one that is private 


        static void Main(string[] args)
        {
            Program4 p = new Program4();
            p.test1();
            p.test3();    // protected working beacuse this class is derived program 1 class
            p.test6();

            //before run check which project name is bold ...
 // change the startup project ... right click on project and click set as startup project 

            Console.ReadKey();
        }
    }
}
