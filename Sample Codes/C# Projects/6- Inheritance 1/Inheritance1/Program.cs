using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Going to create 'Employee' class 'Reference Variable' and Object of 'Employee' Class");
            
            //Create 'Reference Variable' of 'Employee' and assign it object of 'Employee
            Employee empObj = new Employee(); //Create object of Employee
            
            //Call functions of 'Employee' with 'empObj' reference variable
            empObj.Show();
            empObj.Show1();
            empObj.ToString();

            System.Console.WriteLine("Going to create 'Manager' class 'Reference Variable' and Object of 'Manager' Class");
            
            // Here when Manager Object will be created, it will create internally first Object of its parent or parents            
            Manager mgrObj = new Manager(); //Create Object of Manager

            // So when we'll access properties or methods by using 'mgrObj', it will first search in itself, if found good otherwise will go to parent and so on.
            // It will contain all properties and methods of parent/s, which are public or protected in parent
            mgrObj.Show();
            mgrObj.Show1();
            mgrObj.ToString();

            System.Console.WriteLine("Going to create 'Employee' class 'Reference Variable' and Object of 'Manager' Class");

            /*---------------How Parent Class 'Reference Variable' can point to 'Child Class Objects' --------------*/
            /* Reference Variable of Parent Class Can hold Object of any child class in its heriarchy
             * Here emp (Reference Variable of Parent class) is pointing to Object of Manager (Child Class) 
             * Now as emp of variable of "Employee", with dot only properties & functions which are in "Employee" can be called
            */
            Employee emp = new Manager();
            emp.Show(); //
            emp.Show1();

            // Note: Child class Object can't point to parent class object
            // Manager mgr = new Employee(); //Invalid Statement

            System.Console.WriteLine("Going to create 'Employee' class 'Reference Variable' and Object of 'SeniorManager' Class");
            Employee emp1 = new SeniorManager();

            System.Console.WriteLine("Going to create 'Manager' class 'Reference Variable' and Object of 'SeniorManager' Class");
            Manager mgr1 = new SeniorManager();

            System.Console.WriteLine("Going to create 'SeniorManager' class 'Reference Variable' and Object of 'SeniorManager' Class");
            SeniorManager mgr2 = new SeniorManager();


            //To stop the console so user presses a key to exit application
            System.Console.ReadKey();
        }
    }
}
