using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace L4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            //user input 

            Console.WriteLine("Enter your name : ");

            //String Input 
            string name=Console.ReadLine();
            Console.WriteLine(name);


            // basically Console.Readline() take always string input so if we want to take int , float , double or any other data type input
            // so we need to convert or parsing method 

            Console.WriteLine(" integer input : ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(" integer parse : " + i);

            Console.WriteLine("float input : ");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(" float parse : "+ f);

            Console.WriteLine(" double input :");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(" double parse : " + d);

            Console.WriteLine(" boolean input : ");
            bool b = Boolean.Parse(Console.ReadLine());
            Console.WriteLine(" boolean parse : " + b);







            // more way to take input 
          
           /* Console.WriteLine("Enter your age : ");

            // Integer Input  
            int age = Convert.ToInt32(Console.ReadLine()); //Breakdown : //  string ageInput = Console.ReadLine();
            Console.WriteLine(age);                                                      // int age = Convert.ToInt32(ageInput);


            Console.WriteLine("Enter double number : ");
            
            // Double Input 
            double D = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine(D);


            Console.WriteLine("Enter float value : ");
            //Float Input 
            float F = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(F);*/





            // unary operators for condition == > >= <= < != || && 



            // Conditional statement 

            if (false)
            {
                Console.WriteLine("if");
            }
            else if (true)
            {
                Console.WriteLine("else if");
            }
            else if (false)
            {
                Console.WriteLine("2nd else if");
            }
            else
            {
                Console.WriteLine("else");
            }

            int day = 2;
            switch (day)
            {
                case 1: 
                    Console.WriteLine("day 1");
                    break;
                case 2: 
                    Console.WriteLine("day 2");
                    break;
                case 3:
                    Console.WriteLine(" day 3");
                    break;
                default:
                    Console.WriteLine(" no day ");
                    break;
            }

            char a = 'b';
            switch (a)
            {
                case 'a':
                    Console.WriteLine("A");
                    break;
                case 'b':
                    Console.WriteLine("B");
                    break;
                case 'c':
                    Console.WriteLine("C");
                    break;
            }




            Console.ReadKey();


        }
    }
}
