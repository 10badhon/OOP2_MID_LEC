using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Dimensional 

            int[] number1D = new int[3];
            // number1D[0] = 
            number1D[1] = 10;
            number1D[2] = 5;

            for (int i = 0; i < number1D.Length; i++)
            {
                Console.WriteLine("index [" + i + "] " + number1D[i]);
            }

            int[] num1D = new int[] { 11, 22, 33, 44, 55 };  // Not need to define array size when you can assign value on array declare time 


            foreach (int i in num1D) // using foreach loop por serial print 
            {
                Console.WriteLine("foreach Loop " + i);
            }


            // multidimensional array 

            int[,] number2D = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            Console.WriteLine("prev val " + number2D[0, 0]);
            number2D[0, 0] = 100;   // replaced with new value 
            Console.WriteLine("now val " + number2D[0, 0]);

            Console.WriteLine("num of element " + number2D.Length); // number of element 
            Console.WriteLine("num of dimension " + number2D.Rank); // number of dimensions

            Console.WriteLine();

            for (int i = 0; i < number2D.GetLength(0); i++)             // (0) means row
            {
                for (int j = 0; j < number2D.GetLength(1); j++)         // (1) means column
                {
                    Console.Write(number2D[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,,] number3D = new int[2, 3, 4];      // 3 dimensional 
            int[,,,] number4D = new int[3, 3, 3, 4]; // 4 dimensional



            // Jagged array 
            // Jagged array is a array which can be stored others array

            int[][] jaggedarray = new int[3][];   // 1D jagged array & store 1D arrays
            int[][,] arr = new int[3][,]; // 1D jagged array & store 2D arrays 

            jaggedarray[0] = number1D;
            jaggedarray[1] = new int[] { 10, 20, 30 };
            jaggedarray[2] = new int[] { 2, 4, 6, 8 };


            //jaggedarray[JA_index][index of element array inside JA_index]
            Console.WriteLine("prev val " + jaggedarray[1][1]);
            jaggedarray[1][1] = 200;
            Console.WriteLine("now val " + jaggedarray[1][1]);


            for (int i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine($"jagged array index {i}");      // using $ sign so that you can store value using {}
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.Write(jaggedarray[i][j] + " ");
                }
                Console.WriteLine();
            }


            int[,][,] jaggedarray4 = new int[2, 2][,]      // this jagged array is 2D size [2, 2] && it can store 2D arrays [,]
            {
                {
                    new int[,] { {1,2} , {3,4} },
                    new int[,] { {7,8}, {9,10},{11,12} }
                },
                {
                    new int[,] { { 11, 22 }, {33,44}, {55,66} },
                    new int[,] { { 77, 88 }, { 99,32}, { 75, 85 }, { 95,45}}
                }
            };

            Console.WriteLine(jaggedarray4[0, 1][2, 1]);
            jaggedarray4[0, 1][2, 1] = 200;
            Console.WriteLine(jaggedarray4[0, 1][2, 1]);                              Console.WriteLine();

            for(int i = 0; i<jaggedarray4.GetLength(0); i++)                  //GetLength(0) means row 
            {
                for(int x=0; x<jaggedarray4.GetLength(1); x++)                //GetLength(1) means column 
                {
                    Console.WriteLine($"jagged array index {i}{x}");
                    for(int a=0; a<jaggedarray4[i,x].GetLength(0); a++)       // JA index array rows length || jaggedarray4[i,x].GetLength(0)
                    {
                        for(int b=0; b<jaggedarray4[i,x].GetLength(1); b++)   // JA index array column lenght || jaggedarray4[i,x].GetLength(1)
                        {
                            Console.Write(jaggedarray4[i, x][a, b] + " ");
                        }
                        Console.WriteLine();
                    }  
                }
            }

            Console.ReadKey();
        }
    }
}
