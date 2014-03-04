using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LearnProgramming.Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Section 1 ---------------------------------------------------------*/
            
            One obj1 = new One();
            Two obj2 = new Two();
            One obj3 = new Two();
            //Two obj4 = new One();

            obj1.PShowOne();

            obj2.PShowOne();
            obj2.PShowTwo();

            obj3.PShowOne();


            /*Section 2 ---------------------------------------------------------*/

            //Car carObj = new Car();

            Car suz = new Suzuki();
            suz.BuildCar();
            suz.Drive();

            Car hond = new Honda();

            hond.BuildCar();
            hond.Drive();
            
            /*Section 3 ---------------------------------------------------------*/

            Employee emp = new Employee();

            emp.CalculateTax();
            emp.ShowNetSalary();

            Employee mgr = new Manager();

            mgr.CalculateTax();
            mgr.ShowNetSalary();


            Employee sup = new SupportEmployee();

            sup.CalculateTax();
            sup.ShowNetSalary();
            //sup.SpecialShow();

            SupportEmployee ssp = (SupportEmployee)sup;

            ssp.CalculateTax();
            ssp.ShowNetSalary();
            ssp.SpecialShow();

            /*Section 4 ---------------------------------------------------------*/
            
            CustomerDAL customer = new CustomerDAL(DataBaseTypes.SqlDatabase);

            customer.SaveCustomer("abc");
            customer.DeleteCustomer("1");

            CustomerDAL newCust = new CustomerDAL(DataBaseTypes.MySqlDatabase);

            newCust.SaveCustomer("ddd");
            newCust.DeleteCustomer("2");
   
            

            System.Console.ReadKey();
        }
    }



    
}


