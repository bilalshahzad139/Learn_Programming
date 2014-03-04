using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Name Spaces are logic unit to Hold classes
namespace LearnProgramming.StaticKeyword
{
    //a non-static class
    public class Customer
    {
        //This is class level variable, will not be part of 'Object'/'Instance'
        private static int counter = 0;

        //Instance level variables
        private int a;
        private int b;
        private int c;

        public Customer(int aa,int bb,int cc)
        {
            Console.WriteLine("Customer: Constructor is fired");
            counter++;
            a = aa;
            b =bb;
            c = cc;
        }

        //static & non-static members can be accessed in 'non-static'/instance functions
        public void Show()
        {
            ShowCounter(); //static function can be access in non-static function
            Console.WriteLine("Counter={0}", counter); //static member can be accessed in non-static function
            Console.WriteLine("a={0}, b={1}, c={2}",a,b,c); 
        }

        //only static members can be accessed in static functions
        public static void ShowCounter()
        {
            //Show(); ---------------- ERROR: this can't be called as this is not static function
            //a=10 ---------------- ERROR: this can't be called as this is not static member

            //'counter' can be accessed as this is 'static' variable
            Console.WriteLine("Counter={0}", counter);
        }
    }


    
}
