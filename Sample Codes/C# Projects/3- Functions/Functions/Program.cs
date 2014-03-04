using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Functions
{
    class Program
    {
        //Main function which is starting point of our execution
        static void Main(string[] args)
        {
            //Call a function which is defined after Main method
            ShowMessage();

            //Call function by passing two arguments
            ShowLine("*", 20);
            
            //Print a message on screen
            System.Console.Write("Enter First Number:");

            //Read text from console, convert it into int and store it in a variable
            int a = Convert.ToInt32(System.Console.ReadLine());

            //Print a message on screen
            System.Console.Write("Enter Second Number:");
            
            //Read text from console, convert it into int and store it in a variable
            int b = Convert.ToInt32(System.Console.ReadLine());

            //Call a function, pass two arguments to it and store result in a variable
            int r = Sum(a,b);

            //print result on screen
            System.Console.WriteLine("Result is:{0}", r);
            
            //Call a function and print its result directly to console
            System.Console.WriteLine("Result is:{0}", Power(5, 3));

            //call a function by passing one argument and store result in a variable
            long r1 = Factorial(5);

            //print result on screen
            System.Console.WriteLine("Result is:{0}", r1);


            //Declare an array of size = 5
            int[] ar = new int[5];

            for (int i = 0; i < 5; i++)
            {
                System.Console.Write("Enter value for {0} index", i);
                ar[i] = Convert.ToInt32(System.Console.ReadLine());
            }

            //Take a number from user.
            int numb = 0;
            System.Console.Write("Enter number to search in array");

            //Read from console, convert into int and store in a number
            numb = Convert.ToInt32(System.Console.ReadLine());

            //Call a function, pass array, size and number to search
            int index = FindElement(ar, 5, numb);

            //print result on console
            System.Console.WriteLine("Element {0} is found at index {1}", numb, index);

            //Wait for a key to exist main method
            System.Console.ReadKey();

        }

        //A function which is taking an 'array', size of array and a number to find in array
        static int FindElement(int [] arr, int size, int numb)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == numb)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //A function which is taking two parameters and not returning anything
        static void ShowLine(String ch,int len)
        {
            for (int i = 0; i < len; i++)
            {
                System.Console.Write(ch);
            }
            System.Console.WriteLine("");
        }

        //A function which is taking two parameters and returning an int
        static int Sum(int a, int b)
        {
            int s = a + b;
            return s;
        }

        //Function with same name but different paramerts - "Method Overloading"
        static int Sum(int a, int b, int c)
        {
            int s = a + b + c;
            return s;
        }

        //Computer a^b where a is base and b is power of it
        static long Power(int b, int p)
        {
            long result = 1;

            for (int i = 1; i <= p; i++)
            {
                result = result * b;
            }

            return result;
        }

        //Find Factorial of a number
        static long Factorial(int numb)
        {
            long result = 1;

            for(int i=1;i<=numb;i++)
            {
                result = result * i;
            }
            return result;
        }

        // a function which simply showing some messages on screen
        static void ShowMessage()
        {
            ShowLine("*", 20);
            System.Console.WriteLine("Welcome to this application");
            System.Console.WriteLine("Here is functions practice");
            ShowLine("-", 20);
        }

    }
}
