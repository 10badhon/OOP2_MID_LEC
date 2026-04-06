using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class GrandPerson
    {
        public GrandPerson()  // creating default constructor explicitly ( shob class ei default constructor thake dekha jay na kintu explicitly eivhabe samne ana jay)
        {                  
            Console.WriteLine("GrandPerson default Cons");
        }
    }
    class Person
    {
        string name;
        int id;
        public int age;
        public Person()
        {
            Console.WriteLine("Person default Cons");
            // also assinging deault value on class member automatically ( name="null" , id=0 ) 
        }
        
    }
    class Student : Person // inheritance 
    {
        public Student()
        {
            Console.WriteLine("Student default Cons");
        }
        float cgpa;

    }
    class Teacher : Person
    {
        public double salary;
        public Teacher(int x)   // if you set parameterized constructor you must have default constructor beacause
                                // when you are creating object without parameter like Teacher() its will throw an error 

        {
            Console.WriteLine("Teacher Parameterized Cons");
        }

        public Teacher()    // declare default constructor because when you create teacher class object with parameter Teacher(100)
                            // if you need another object without parameter Teacher() its will throw an error
                            // that why you need to create a default constructor explicitly 
        {
            Console.WriteLine("Teacher default cons");
        }


        public Teacher(Teacher t)    // copy constructor ( this constructor will copy the parameter object all value everything )
        {
            this.salary = t.salary;
        }
    }


    class program
    {
        static void Main(string[] args)
        {
            Student s = new Student();                      Console.WriteLine();

            Teacher t = new Teacher();                      Console.WriteLine();
            Teacher t1 = new Teacher(100);    // parameterized constructor              
                                                            Console.WriteLine();

            Person p = new Student();    // Upcasting / Runtime polymorphism  ( base class Person || derived class Student )
                                         // A parent (base class) reference can hold a child (derived class) object
                                            Console.WriteLine();

            Person p1 = t; ;  // Upcasting    ( more details in polymorphism lecture ) 
            
            
            
            
            GrandPerson gp = new GrandPerson();                                                                 Console.WriteLine();
            // Person p2 = gp; // Error ( there have no inheritance relation in GrandPerson and Person )


            Teacher t2 = new Teacher();                                                                           Console.WriteLine();
            t2.salary = 10.00;

            Teacher t3 = new Teacher(t2);    // copying t2 object everything in t3 object 
            Console.WriteLine(t3.salary);        // check when you creating teacher object teacher parent class default parameter always run  


            Console.ReadKey();
        }
    }
}