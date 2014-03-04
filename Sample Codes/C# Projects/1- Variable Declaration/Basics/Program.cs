using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Basics
{
    class Program
    {
        //Main entry point of program execution
        static void Main(string[] args)
        {

            //Single line comment

            /* Multi line comment
             * asdfasdf
             * 
             */


            //Variable declaration & Data Types in c#
            //http://msdn.microsoft.com/en-us/library/ms228360(v=vs.90).aspx

            //These both are same
            Byte b1 = 0; //This is base system data type to store small integer data,1 byte of size
            byte b2 = 0; // alias of 'Byte' in C#

            //These both are same
            Int16 sh1 = 0; //This is base system data type to store integer data,2 byte of size
            short sh2 = 0; // alias of 'Int16' in C#

            //These both are same
            Int32 i1 = 0; //This is base system data type to store integer data,4 byte of size
            int i2 = 0; // alias of 'Int32' in C#

            //These both are same
            Int64 lon1 = 0; //This is base system data type to store bigger integer data, 8 byte of size
            long lon2 = 0; //alias of 'Int64' in C#

            //These both are same
            Single fl1 = 0.0f; //This is base system data type to store floating point data, 4 byte of size
            float fl2 = 0.0f; //alias of 'Single' in C#

            //These both are same
            Double dbl1 = 0.0; //This is base system data type to store bigger floating point data, 8 byte of size
            double dbl2 = 0.0; //alias of 'Double' in C#

            //These both are same
            Decimal dec1 = 0.0M; //This is base system data type to store very bigger floating point data, 16 byte of size
            decimal dec2 = 0.0M; //alias of 'Decimal' in C#

            //These both are same
            Char ch1 = 'a'; //This is base system data type to store one character (unicode symbols), 2 byte of size
            char ch2 = 'a';//alias of 'Char' in C#

            //These both are same
            Boolean bol1 = true; //This is base system data type to store true or false), 1 byte of size
            bool bol2 = false;//alias of 'Boolean' in C#

            //These both are same
            String str1 = "Hello World"; //This is base system data type to store string data
            string str2 = "Hello World";//alias of 'String' in C#


            //These both are same
            Object obj1 = new Object(); //This is base system data type. This is base type for all objects
            object obj2 = new object(); //alias of 'Object' in C#


            /*--------------Types conversion ----------------------*/

            //b1 of 'Byte' type will be automatically converted to 'int' (implicit conversion)
            int new_var = b1; //smaller data types variables can be assigned to bigger data types

            //byte new_var1 = i1; //Bigger data types variables can be assigned to smaller data types (implicityly);

            byte new_var2 = (byte)i1; //Explicit type casting




            //How to print a message on Console
            System.Console.WriteLine("Enter First Number");

            //Read input from Console, this will return string data
            string input = System.Console.ReadLine();

            //Print a message on Console
            System.Console.WriteLine("Enter Second Number");

            //Read input from Console, this will return string data
            string input2 = System.Console.ReadLine();

            //Convert string to int
            int first = Convert.ToInt32(input);
            
            //Convert string to int
            int second = Convert.ToInt32(input2);

            int sum = first + second;

            //print data on console by providing a 'format' 
            //in this case {0} will be replaced by 'first variable and so on
            System.Console.WriteLine("Sum of {0} and {1} is {2}", first,second,sum);

            //Display data by using concate approach
            System.Console.WriteLine("Sum of " + first + " and " + second + " is " + sum);


            //If condition in C#
            if (first > second)
            {
                System.Console.WriteLine("first is greater");
            }
           

            //If/else condition in C#
            if (first > second)
            {
                System.Console.WriteLine("first is greater");
            }
            else
            {
                System.Console.WriteLine("second is greater");
            }


            //If/else if condition in C#
            if (first > second)
            {
                System.Console.WriteLine("first is greater");
            }
            else if(first < second)
            {
                System.Console.WriteLine("second is greater");
            }

            
            //To stop console to wait for a key to exit Main method
            System.Console.ReadKey();

        }
    }
}
