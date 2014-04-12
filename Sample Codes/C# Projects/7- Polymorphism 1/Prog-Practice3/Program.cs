using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog_Practice3
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------set some value to abstract class static variables
            Shape.counter = 5;

            //----------Following statement is not allowed, we can't create Object of abstract class
            //Shape shObj = new Shape();

            /*----------We can create 'Reference Variable' of abstract class*/
            Shape shObj = null;

            /*---------Create object of child class and assign it to parent class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Shape,  Object:Square-------------------------");
            shObj = new Square();
            shObj.Show();
            shObj.Draw();
            shObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(shObj);

            Console.WriteLine("-----------------End-------------------------------------");

            /*---------Create object of child class and assign it to parent class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Shape,  Object:Rectange-------------------------");
            shObj = new Rectange();
            shObj.Show();
            shObj.Draw();
            shObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(shObj);

            Console.WriteLine("-----------------End-------------------------------------");

            /*---------Create object of child class and assign it to parent class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Shape,  Object:Triangle-------------------------");
            shObj = new Triangle();
            shObj.Show();
            shObj.Draw();
            shObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(shObj);

            Console.WriteLine("--------------Type Casting..Reference Var:Triangle,  Object:Triangle-------------------------");

            //As shObj refering to 'Trainage' object, we can type cast to it 'Triangle'
            Triangle triangObj = (Triangle)shObj;

            triangObj.Show();
            triangObj.Draw();
            triangObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(triangObj);

            Console.WriteLine("-----------------End-------------------------------------");


            /*---------Create object of child class and assign it to child class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Square,  Object:Square-------------------------");
            Square sqObj = new Square();
            sqObj.Show();
            sqObj.Draw();
            sqObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(sqObj);

            Console.WriteLine("-----------------End-------------------------------------");

            /*---------Create object of child class and assign it to child class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Rectange,  Object:Rectange-------------------------");
            Rectange rqObj = new Rectange();
            rqObj.Show();
            rqObj.Draw();
            rqObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(rqObj);

            Console.WriteLine("-----------------End-------------------------------------");


            /*---------Create object of child class and assign it to child class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Triangle,  Object:Triangle-------------------------");
            Triangle trObj = new Triangle();
            trObj.Show();
            trObj.Draw();
            trObj.HideMe();

            //Call method which takes any object of type 'Shape'
            DoSomething(trObj);

            Console.WriteLine("-----------------End-------------------------------------");

            Console.WriteLine("---------------Custom Object creation----------------------------");

            int type = 0;
            string choice = "";

            do
            {
                Console.WriteLine("Enter 1 to Create 'Square'");
                Console.WriteLine("Enter 2 to Create 'Rectangle'");
                Console.WriteLine("Enter 3 to Create 'Triangle'");

                //Get a number from user
                type = Convert.ToInt32(System.Console.ReadLine());

                //Function will return object of type 'Shape' which would be refering to 'Square' or 'Rectange' or 'Trinage'
                Shape sObj = GetObject(type);

                //Call 'Draw' method. It will be decided at run time based on the available object in 'sObj'
                sObj.Draw();
                sObj.Show();

                Console.Write("Do you want to create again? (Y/N):");
                choice = System.Console.ReadLine();
            }
            while (choice == "Y" || choice == "y");


            Console.WriteLine("-----------------End-------------------------------------");


            /* 'Object' is base class of every class eventually
             * so it can hold reference of object of any calls */

            Object o1 = new Object();
            Object o2 = new Triangle();
            Object o3 = new Square();
            Object o4 = new Rectange();


            //To stop the console so user presses a key to exit application
            System.Console.ReadKey();
        }//End of Main

        //Based on variable and return 'Shape' variable
        public static Shape GetObject(int flag)
        {
            Shape shObj;

            if (flag == 1) //Let say '1' is for Squar
            {
                shObj = new Square();
            }
            else if (flag == 2) //Let say '2' is for Squar
            {
                shObj = new Rectange();
            }
            else if (flag == 3) //Let say '3' is for Triange
            {
                shObj = new Triangle();
            }
            else
                shObj = null;

            return shObj;
        }


        //This method is taking object of type 'Shape'
        public static void DoSomething(Shape sh)
        {
            //Top level class is 'Object' and it contains a method 'GetType()'
            Console.WriteLine("Type of sent object in 'sh' is:{0}", sh.GetType().Name);
            sh.Draw();
        }
    }
}
