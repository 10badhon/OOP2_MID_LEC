using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{        
          // Method Parameter Modifier 
          // Ref keyword ( ref = reference || work like pointer )
          // out keyword ( out = output || multiple return )
          // params keyword ( set parameter for unknown number of arguement )
          
    class Program
    {    
        public static void swap( ref int x, ref int y) // called method 
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Calculation(int x , int y , out int sum , out int sub , out int mul , out int div )
        {     
            // sum sub mul div eishob variable faka jete parbe na value thakte hobe noile error dibe ( jemon porer 4 ta line e 4 tar e value assign hobe )
              
            sum = x + y;
            sub = x - y;
            mul = x * y;     // 4 ta line er moddhe jekono ekta comment out koro dekhba caculation er moddhe error show korbe hover korle dekhte parba ki ki missing 
            div = x / y; 
        }

        public static void Print(params int[] numbers)
        {
            Console.WriteLine("there are {0} number of elements", numbers.Length);
            
            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers.Length + " , ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

                                                                            Console.WriteLine("---Ref keyword--- \n");

            Console.WriteLine("before swap a = {0} & B = {1} ",a,b);

            swap(ref a, ref b); // calling method 
                                //sending a and b variable memeory address to swap method so swap will work properly
                                // if we dont use ref keyword so swap method will swap on a copy of a and b varibla 
            
            // without ref keyword its -> called by value this is default for any parameter 
            // with ref keyword its -> called by reference 

            Console.WriteLine("after swap a = {0} & B = {1} ", a, b);

                                                                           Console.WriteLine();
                                                                           Console.WriteLine("---Out keyword--- \n");  

            int sum, sub, mul, div;

            Calculation(a, b, out sum, out sub, out mul, out div); // out keyword use kora hoy multiple value return korar jonno 

            Console.WriteLine("sum {0} sub {1} mul {2} div {3} ",sum,sub,mul,div);



                                                                           Console.WriteLine();
                                                                           Console.WriteLine("---Params keyword--- \n");

            Print(10,20);
            Print(100);
            Print();
            Print(1, 2, 3, 4, 5);




            Console.ReadKey();
        }
    }
}
//     difference between out keyword and ref keyword 
// out keyword --> parameters do not need to be initialized value before use in a called method. 
// ref keyword --> parameters must be initialized value before sending to called methodn otherwise its act like null pointer 
