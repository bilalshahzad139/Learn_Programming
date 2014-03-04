using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.LoopsArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Loop Syntax
            
            //Counter LOOP
            System.Console.WriteLine("-------For Loop---------------");
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Value is {0} :", i);
            }

            System.Console.WriteLine("-------While Loop---------------");
            //Conditional Loop (while loop)
            int j = 0;
            while (j < 10)
            {
                System.Console.WriteLine("Value is {0} :", j);
                j++;
            }

            System.Console.WriteLine("-------do while Loop---------------");
            //do-while loop
            int k = 0;
            do
            {
                System.Console.WriteLine("Value is {0} :", k);
                k++;
            } while (k < 10);

            
            int size = 5;
            //Arrays
            //here we have created an array of type 'int' of 5 elements
            int[] arr = new int[size];
            
            string str = "";

            System.Console.WriteLine("-------Take data for Array---------------");
            //Run the loop till size and take elements into array
            for (int i = 0; i < size; i++)
            {
                //Print message on screen
                System.Console.Write("Enter value :");
                
                //read line from console
                str = System.Console.ReadLine();                
                
                //convert string into int and store in array
                arr[i] = Convert.ToInt32(str);
            }

            System.Console.WriteLine("-------Print values of array---------------");
            //print all values of the array
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Value at {0} is {1} ", i, arr[i]);
            }

            System.Console.WriteLine("-------For Each Loop---------------");
            //foreach loop is used to iterated an array
            foreach (int val in arr)
            {
                System.Console.WriteLine("Value is {0} ", val);
            }


            //wait for a key to exit main method
            System.Console.ReadKey();

        }
    }
}
