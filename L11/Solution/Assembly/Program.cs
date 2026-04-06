using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    
    class Person
    {
        string _name;
        int _id;
        int _age;
        
        public Person()
        {
            Console.WriteLine("person Default cons");
        }

        public Person(string name, int id , int age)   // paramerterized cons
        {
            this._name = name;
            this._id = id;
            this._age = age;
        }

        public string Name
        {
            set {
                this._name = value; 
            }
            get
            {
                return this._name;
            }
        }
        public int Id
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public int Age
        {
            set
            {
                this._age = value;
            }
            get
            {
                return this._age;
            }
        }

        
    }
    class Student
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person[] p = new Person[3];

            for(int i=0; i<p.Length; i++)    // taking user input for all person
            {
                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter id : ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter age : ");
                int age = int.Parse(Console.ReadLine());

                p[i] = new Person(name, id, age);

            }

            for(int i=0; i<p.Length; i++)
            {
                Console.WriteLine("Person "+i+" : "+p[i].Name+" "+p[i].Id+" "+p[i].Age);
            }


            // Direct initalization without user input 

            Student[] s = new Student[3];

            s[0] = new Student();
            s[0].Name = "Rahim";
            s[0].Age = 20;

            s[1] = new Student();
            s[1].Name = "Karim";
            s[1].Age = 21;

            s[2] = new Student();
            s[2].Name = "Salma";
            s[2].Age = 22;

            Console.ReadKey();
           



        }
    }
}
