using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //System is a namespace here
            //Consol is a class in System namespace
            //WriteLine is a 'static' method in 'Console' class
            System.Console.WriteLine("Hello World");

            //This is creating only 'Reference Variable/Pointer' of type 'Employee'. It is not an object
            Employee emp;

            //On left side, it is creating 'Reference variable/pointer' of type 'Employee'
            //On right side, it is creating 'Object' of type 'Employee' using 'new' operator
            //and empObj is holding address/reference of that object
            Employee empObj = new Employee();
            
            //Now set values of above created object using 'embObj' variable
            empObj.id = 1;
            empObj.age = 20;
            empObj.name = "waqas";

            //New get values from the object and print on the screen
            System.Console.WriteLine("ID :" + empObj.id);
            System.Console.WriteLine("Age " + empObj.age);
            System.Console.WriteLine("Name " + empObj.name);

            System.Console.WriteLine("-------------------------------------------");

            //Create another Reference Variable + Object using Paramterized Constructor
            Employee empObj1 = new Employee(2, 25, "waqas");

            //New get values from the object and print on the screen
            System.Console.WriteLine("ID :" + empObj1.id);
            System.Console.WriteLine("Age " + empObj1.age);
            System.Console.WriteLine("Name " + empObj1.name);


            //To stop the console so user presses a key to exit application
            System.Console.ReadKey();
        }
    }
}
