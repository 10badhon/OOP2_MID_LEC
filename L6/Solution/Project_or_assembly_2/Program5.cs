using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_or_assembly_1;  // adding reference for using any member of Project_1


namespace Project_or_assembly_2
{
    class Program5
    {
       
       static void Main(string[] args)
        {
           // Project_or_assembly_1.Program1 p = new Project_or_assembly_1.Program1();


            Program1 p = new Program1();    //add using reference because program 1 is not this project class 
            p.test1();

            Console.ReadKey();
        }  
      
    }
}
