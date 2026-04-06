using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
             
          // Inheritance & Super keyword                
          // base is super keyword in java 
namespace Project
{
    class A {
        public string color;
        public int age;
        public double number;



        public A()
        {
            this.number = 200;
        }
        public A(string color , int age)
        {
            this.color = color;
            this.age = age;

            this.number = 100;
        }
        
     }
    class B : A  // B class inherit A class ( A is base or parent class || B is child or derived class ) 
    {
        public double salary;
        
        public B()
        {

        }

        public B(double salary , string color, int age) : base(color, age)   // assinging parent class color and age through
                                                                             // calling parent class parameter constructor with base keyword 
        {
            this.salary = salary;

            /* base.age = age;            // you can also assign value like this way 
             base.color = color; */

            Console.WriteLine(base.number);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            A aa = new A();
            Console.WriteLine("color : " + aa.color + " age : " + aa.age);

            B bb = new B(2000,"yellow",10);

            Console.WriteLine("color : " + bb.color + " age : " + bb.age); // child class can hold parent class members ( not assign this value in ( A class ) parmanently because its a copy of bb object ) 

            Console.WriteLine("color : " + aa.color + " age : " + aa.age); // also aa object dont have any color or age because aa is another object || different object hold different copy different memory , not static memory  

            Console.ReadKey();
        }
    }
}
                  