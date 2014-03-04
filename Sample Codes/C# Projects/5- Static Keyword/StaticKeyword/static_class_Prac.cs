using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Name Spaces are logic unit to Hold classes
namespace LearnProgramming.StaticKeyword
{

    //---------------ERROR: static class can dervie from 'Object' class.
    //static class MyMath : XYX ------- ERROR
    //static class MyMath : Object ---------- Valid
    
    //static class can't be inherited
    //instance of static class can't be created
    //static class is ideal example of 'Singleton' design pattern (Only One instance, created automatically)

    static class MyMath
    {
        private static int privCounter = 0;
        public static int pubCounter = 0;

        //---------------ERROR: cannot declare instance members in a static class
        //private int a;


        //---------------ERROR: static class cann't have 'INSTANCE'/Non-static constructor, it should be static
        /*private MyMath()
        {
        }
         */

        //---------------ERROR: Access modifiers are not allowed with static constructors
        //public static MyMath(){}  ------------- Error

        //static constructor is fired whenever first hit is made to any data/function member of the class
        static MyMath()
        {
            Console.WriteLine("MyMath:Default Constructor is fired");
        }

        //---------------ERROR: a static constructor must be parameterless
        /*static MyMath(int i)
        {
            Console.WriteLine("MyMath:Default Constructor is fired");
        }*/

        public static void ShowPublic()
        {
            Console.WriteLine("MyMath:ShowPublic");
        }
        
        private static void ShowPrivate()
        {
            Console.WriteLine("MyMath:ShowPrivate");
        }

        //'internal' means accessible inside assembly, static means, accessible by class name
        internal static void ShowInternal()
        {
            Console.WriteLine("MyMath:ShowInternal");
        }

        //---------------ERROR: static classes cannot contain protected members
        /*protected static void ShowProtected()
        {

        }
        
        protected internal static void ShowProtectedInternal()
        {
            Console.WriteLine("MyMath:ShowProtectedInternal");
        }
         * 
         */
    }//End of class


    
}
