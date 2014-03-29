using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.StaticKeyword
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //static keyword use
            //Customer obj = new Customer(); ----ERROR: No default constructor is available

            //Create 'custObj' as 'Reference Variable' and an object by using 'new' keyword + Customer constructor
            Customer custObj = new Customer(10, 20, 30);
            //Call its show function
            custObj.Show();

            //Create 'custObj1' as 'Reference Variable' and an object by using 'new' keyword + Customer constructor
            Customer custObj1 = new Customer(100, 200, 300);
            //Call its show function
            custObj1.Show();

            //Create 'custObj2' as 'Reference Variable' and an object by using 'new' keyword + Customer constructor
            Customer custObj2 = new Customer(1000, 2000, 3000);
            //Call its show function
            custObj2.Show();



            //Singleton practice
            DBManager obj; //Reference variable, No-ERROR

            //----------ERROR: Constructor is private so can't create 'OBJECT' outside of class
            //obj = new DBManager();


            //Call static function with Class name which will return Object
            obj = DBManager.GetInstance();

            obj.SetI(20);
            obj.ShowI();

            //Call static function with Class name which will return Object
            obj = DBManager.GetInstance();
            obj.ShowI(); //It will print 20 as obj is pointing to same object


            //Static class examples
            Console.WriteLine("Going to access static class members for first time, constructor should fired");
            
            //access static variable by class name and assign it a value
            MyMath.pubCounter = 20;

            Console.WriteLine("Going to call ShowPublic");
            //access static function by class name
            MyMath.ShowPublic();

            Console.WriteLine("Going to call ShowInternal");
            //access static function by class name
            MyMath.ShowInternal();



            //To stop the console so user presses a key to exit application
            System.Console.ReadKey();
        }
    }
}
