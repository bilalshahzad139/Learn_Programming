using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Name Spaces are logic unit to Hold classes
namespace LearnProgramming.StaticKeyword
{

    //Singelton design pattern is used to create only 'INSTANCE'/'OBJECT' of the class
    public class DBManager
    {
        //We need to create a local private variable of this call inside class to hold single object
        private static DBManager myobject;
        //instance data
        private int i = 0;
        //'private' constructor, so no one can create object of this class outside of this class
        private DBManager()
        {

        }

        //This function is public and static and it will return 'Instance' of 'DBManager' class
        public static DBManager GetInstance()
        {
            //check if this is first call from outside world
            if (myobject == null)
                myobject = new DBManager(); //This can be called inside class but not outside class as constructor is private

            //return object
            return myobject;
        }

        //non-static function
        public void Show()
        {
            Console.WriteLine("DBManager:Show()");
        }

        //non-static function
        public void SetI(int val)
        {
            i = val;
        }

        //non-static function
        public void ShowI()
        {
            Console.WriteLine("DBManager:ShowI(), Value of I=" + i);
        }
    }//end of class

    
}
