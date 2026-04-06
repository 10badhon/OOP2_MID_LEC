using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// when you create a project that time asked a solution name ... basically Solution can hold multiple project 
// project name and namespace both are same .... a project can contain multiple classes 
// .cs file is basically class file or program file 


// how to create C# file ... first open visual studio --> create a new project --> language : C#
//                                                                                 platform : windows
//                                                                                 project type : console 
//  click console app .net framework than click on next (Done)


// better to use visual studio 2019 as a beginner and if you use 2022 no way to download 2019 so : 
// for 2022 : 
// Go to Tools --> Options --> intellicode --> general --> Uncheck all options except ( Promote likely items..... )
// for better learning that will stop auto suggestion and also auto generate codes ...

namespace L1  // project or assembly is namespace
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");


            //numerical datatype

            int age = 22;
            Console.WriteLine(age);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.00001F; // if you dont put F that means right side value is double so that can not be store in float variable
            Console.WriteLine(precision);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);


            Console.ReadKey(); //using this line sometimes console will close automatically 

        }
    }
}

//.NET Framework is Microsoft’s platform for building and running Windows applications,
// providing a runtime engine and a large set of reusable libraries. 
// .NET Framework provide 60 programming language support thats why .netframework is most popular 

// can build : 
//.NET Framework -→ Windows + Web
// Modern.NET -→ Windows + Web + Mobile + Cloud + More 