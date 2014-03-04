using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Name Spaces are logic unit to Hold classes
namespace LearnProgramming.Inheritance
{

    //A more generic class which will be used as parent class of other classes
    class Employee
    {
        //Class Parameters
        public int id;
        public int age;
        public string name;

        //Default Constructor
        public Employee()
        {
            System.Console.WriteLine("Employee: default constructor is executed");
        }

        //Parameterized Constructor
        public Employee(int i,int a,string n)
        {
            id = i;
            age = a;
            name = n;
            System.Console.WriteLine("Employee: Parameterized constructor is executed");
        }

        public void Show()
        {
            System.Console.WriteLine("Employee: Show()");
        }

        public void Show1()
        {
            System.Console.WriteLine("Employee: Show1()");
        }
    }
    //Manger Class is Inheriting Employee Class
    //Manager will inherit all members (public & protected) of 'Employee' class, 
    //protected will become as they are private in 'Manager'
    class Manager : Employee
    {
        String ManagerCode;
        public Manager()
        {
            System.Console.WriteLine("Manager: Default Constructor");
        }
        public Manager(String mgrCode)
        {
            System.Console.WriteLine("Manager: Parameterized Constructor");
            ManagerCode = mgrCode;
        }
        public void Show()
        {
            System.Console.WriteLine("Manager: Show()");
        }
    }

    //SeniorManager class will inherit public & protected members of Manager class.
    class SeniorManager : Manager
    {
        String ManagerSeniority;
        public SeniorManager()
        {
            System.Console.WriteLine("SeniorManager: Default Constructor");
        }
    }
}
