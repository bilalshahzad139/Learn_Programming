using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Name Spaces are logic unit to Hold classes
namespace Prog_Practice3
{
    interface ICustomer
    {
        int show();
    }


    class MyCustomer : ICustomer
    {
        public int show()
        {
            return 0;
        }
    }



    //Create an abstract class
    abstract class Shape
    {
        //----------static variable in abstract class
        public static int counter;

        //----------normal variable in static class
        private int dimensions;

        //----------Abstract class can't have constructor
        /*void Shape()
        {
        }
         */

        //----------Abstract method
        public abstract void Draw();

        //----------non-abstract but a virtual method
        public virtual void HideMe()
        {
            Console.WriteLine("Shape:HideMe()");
        }

        //----------non-abstracr or Concrete function
        public void Show()
        {
            Console.WriteLine("Shape:Show()");
        }
    }

    class Square : Shape
    {
        //----------Implementation/overriding of abstract method
        public override void Draw()
        {
            Console.WriteLine("Square:Draw()");
        }

        //----------providing new definition of Show
        public void Show()
        {
            Console.WriteLine("Square:Show()");
        }
    }

    class Rectange : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectange:Draw()");
        }
        //----------Overriding of virtual method
        public override void HideMe()
        {
            Console.WriteLine("Rectange:HideMe()");
        }
        
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle:Draw()");
        }

        //----------Providing new definition to virtual method
        public new void HideMe()
        {
            Console.WriteLine("Triangle:HideMe()");
        }
        public void Show()
        {
            Console.WriteLine("Triangle:Show()");
        }
    }
}
