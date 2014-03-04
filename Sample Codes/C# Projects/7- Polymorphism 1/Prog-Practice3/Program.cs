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
            Console.WriteLine("-----------------End-------------------------------------");

            /*---------Create object of child class and assign it to parent class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Shape,  Object:Rectange-------------------------");
            shObj = new Rectange();
            shObj.Show();
            shObj.Draw();
            shObj.HideMe();
            Console.WriteLine("-----------------End-------------------------------------");

            /*---------Create object of child class and assign it to parent class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Shape,  Object:Triangle-------------------------");
            shObj = new Triangle();
            shObj.Show();
            shObj.Draw();
            shObj.HideMe();
            Console.WriteLine("-----------------End-------------------------------------");


            /*---------Create object of child class and assign it to child class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Square,  Object:Square-------------------------");
            Square sqObj = new Square();
            sqObj.Show();
            sqObj.Draw();
            sqObj.HideMe();
            Console.WriteLine("-----------------End-------------------------------------");

            /*---------Create object of child class and assign it to child class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Rectange,  Object:Rectange-------------------------");
            Rectange rqObj = new Rectange();
            rqObj.Show();
            rqObj.Draw();
            rqObj.HideMe();
            Console.WriteLine("-----------------End-------------------------------------");


            /*---------Create object of child class and assign it to child class 'Reference variable' */
            Console.WriteLine("--------------Reference Var:Triangle,  Object:Triangle-------------------------");
            Triangle trObj = new Triangle();
            trObj.Show();
            trObj.Draw();
            trObj.HideMe();
            Console.WriteLine("-----------------End-------------------------------------");




            //To stop the console so user presses a key to exit application
            System.Console.ReadKey();
        }
    }
}
