using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace Assembly
{                                  // C# Property |&| Encapsulation
    class Person{

        int _id;   // by default this member is private || C# by default access modifier is most restricted one that is private
        string _name;

        public int Id // its not a method its called property || method can have parameter 
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }

        }

        public string Name
        {
           
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return "There is no name assigned";
                }
                else
                {
                    return this._name;
                }
            }

            set => _name = value; // => lambda operator using for shortcut instead of { block }
            
        }

        public double Salary //automatically implemented property
        {
            set;
            get;  // must have get accessor why not its can throw an error .   

        } = 1000; // you can set value like this || but if you initialized with other value in main method that can be changed 




        // access modifier uses in property 

        private int age { get; set; } // Only accessible inside the same class because its private 

        public int Idd { get; private set; } // Anyone can read  || only can set value in this class 
                                             // Useful when you want the property to be read-only from outside.

        public void setIdd(int x)
        {
            Idd = x;   // Idd private property on can set value like this way 

        }

        public string Namee { get; protected set; } // Everyone can read || Only derived classes can modify


        // private string Name1 { public get; set; }    ❌ Not allowed || bahire private tahole vhitore r o restriction wala modifier use korte hobe 


       // protected int x { set; protected get; }      error same types can't set || bahirer theke vhitore r o restricted modifier use korte hobe  





    }

    class Program 
    {
        static void Main(string[] args)
        {
            Person p = new Person();
           
            p.Id = 12;

            p.Name = "badhon";

            Console.WriteLine(p.Id);

            Console.WriteLine(p.Name);

            Console.WriteLine(p.Salary); // getting default value that i set on property

            p.Salary = 222222222;

            Console.WriteLine(p.Salary);


            Console.ReadKey();
        }
    }
}


 /*  property is a class member which can be used to encapsulate private fields outside the class environment 
 
 in C# , properties are special kind of methods called accessor
 
 property with only read permission is called get accessor 
 property with only write permission is called set accessor 
 property with both read/write permission is called set/get accessor

 data => read/write    
 
 automatically implemented property 
  
  
  */ 




