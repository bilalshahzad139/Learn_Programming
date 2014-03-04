using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSLearning
{
    //with elements inside namespace, we can use "internal" or "public"
    public static class MathUtility
    {
        private static int i = 0;

        static MathUtility()
        {
            i = 0;
        }
        public static void show()
        {
            Object obj = new object();

            
        }
    }

    public class MathUtility2
    {
        private static int i = 0;
        private int j = 0;
        MathUtility2()
        {
            i++;
        }
        public static void show()
        {
            i = 0;
            //j = 0;
        }
        public void show1()
        {
            i = 0;
            j = 0;
        }
    }
    public class A
    {
        private int priA;
        public int pubA;
        internal int intrA;
        protected int protA;
        protected internal int prot_internA;
    }

    class X
    {
        void Show()
        {
            A obj = new A();
        }
    }

    public class B : A
    {
        private int priB;
        public int pubB;
        internal int intrB;
        protected int protB;
        protected internal int prot_internB;
    }

    public class C
    {
        public int i = 0;
        private int b = 0;
        internal int c = 0;

        void show(C obj)
        {
            obj.i = 0;
            obj.b = 0;
            obj.c = 0;
            
            
        }
    }
}

namespace BSLearning.Advance
{
    public class D
    {
        
        class E
        {
            int i = 0;
            int j = 0;
        }
    }

    interface IEmployee
    {
        String MyName
        {
            get;
            set;
        }
        
        void GetData();
        String ShowData(int a);
    }

    class Manager : IEmployee
    {
        public String MyName
        {
            get;
            set;
        }
        public void GetData()
        {
        }
        public String ShowData(int a)
        {
            return "";
        }
    }

    abstract class Employee
    {
        //abstract void ShowData();
        public abstract void ShowData();
        public virtual void ShowData1()
        {
        }
    }
    class Employee1
    {
        public virtual void ShowData(){}
    }
    //class SalariedEmployee : Employee 
    //{
    //}

}
