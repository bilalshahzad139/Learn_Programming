using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    class One
    {
        public One()
        {
            System.Console.Out.WriteLine("One Constructor");
        }
        public One(int a)
        {
            System.Console.Out.WriteLine("One Constructor with param");
        }
        private void ShowOne()
        {
            System.Console.Out.WriteLine("ShowOne");
        }
        public void PShowOne()
        {
            System.Console.Out.WriteLine("PShowOne");
        }
    }
    class Two : One
    {
        public Two()
        {
            System.Console.Out.WriteLine("Two Constructor");
        }
        public Two(int a)
        {
            System.Console.Out.WriteLine("Two Constructor-with param");
        }
        private void ShowTwo()
        {
            System.Console.Out.WriteLine("ShowTwo");
        }
        public void PShowTwo()
        {
            System.Console.Out.WriteLine("PShowTwo");
        }
    }

    abstract class Car
    {
        public abstract void Drive();
        public void BuildCar()
        {
            Console.WriteLine("Car.BuildCar()");
        }
    }
    class Suzuki : Car
    {
        public override void Drive()
        {
            System.Console.WriteLine("Suzikie Drive");
        }
    }
    class Honda : Car
    {
        public override void Drive()
        {
            System.Console.WriteLine("Honda Drive");
        }
    }

    class Employee
    {        
        protected decimal NetSalary
        {
            get;
            set;
        }
        protected decimal SalaryAmount
        {
            get;
            set;
        }
        protected virtual decimal TaxRate
        {
            get;
            set;
        }
        public virtual decimal CalculateTax()
        {
            Console.WriteLine("Employee.CalculateTax()");
            decimal tax =  (SalaryAmount * TaxRate) ;
            NetSalary = SalaryAmount - tax;
            return NetSalary;
        }
        public void ShowNetSalary()
        {
            Console.WriteLine("Employee.ShowNetSalary()");
            Console.WriteLine("Employee:" + NetSalary);
        }
    }
    class Manager : Employee    
    {
        private String CabinID="";
        protected override decimal TaxRate
        {
            get
            {
                return base.TaxRate;
            }
            set
            {
                base.TaxRate = value;
            }
        }
        public override decimal CalculateTax()
        {
            Console.WriteLine("Manager.CalculateTax()");
            decimal tax = 0;
            if (this.SalaryAmount > 2000)
            {
                tax = (SalaryAmount * TaxRate);                
            }

            NetSalary = SalaryAmount - tax;
            return NetSalary;
        }
        public void ShowNetSalary()
        {
            Console.WriteLine("Manager.ShowNetSalary()");
            Console.WriteLine("Manager:" + NetSalary);
        }
    }
    class SupportEmployee : Employee
    {
        private String NightShift="";

        protected override decimal TaxRate
        {
            get
            {
                return base.TaxRate;
            }
            set
            {
                base.TaxRate = value;
            }
        }

        public override decimal CalculateTax()
        {
            Console.WriteLine("SupportEmployee.CalculateTax()");

            decimal tax = 0;
            if (this.SalaryAmount > 5000)
            {
                tax = (SalaryAmount * TaxRate);
            }

            NetSalary = SalaryAmount - tax;
            return NetSalary;
        }
        public void ShowNetSalary()
        {
            Console.WriteLine("SupportEmployee.ShowNetSalary()");
            Console.WriteLine("SupportEmployee:" + NetSalary);
        }
        public void SpecialShow()
        {
            Console.WriteLine("SupportEmployee.SpecialShow()");
        }
    }

    class SeniorSupportEmployee : SupportEmployee
    {

    }

    interface ICustomDatabase
    {
        void OpenConnection();
        void CloseConnection();
        void ExecuteQuery(String query);
        
    }

    class CustomSqlDataBase : ICustomDatabase
    {
        private String _connString;

        public CustomSqlDataBase(String connString)
        {
            Console.WriteLine("CustomSqlDataBase.CustomSqlDataBase()");
            _connString = connString;
        }
        public void OpenConnection()
        {
            Console.WriteLine("CustomSqlDataBase.OpenConnection()");
            //connection open logic of SqlServer
        }
        public void CloseConnection()
        {
            Console.WriteLine("CustomSqlDataBase.CloseConnection()");
            //connection close logic of 
        }
        public void ExecuteQuery(string query)
        {
            Console.WriteLine("CustomSqlDataBase.ExecuteQuery()");
            //
        }

    }

    class CustomMySqlDataBase : ICustomDatabase
    {
        private String _connString;

        public CustomMySqlDataBase(String connString)
        {
            Console.WriteLine("CustomMySqlDataBase.CustomMySqlDataBase()");
            _connString = connString;
        }
        public void OpenConnection()
        {
            Console.WriteLine("CustomMySqlDataBase.OpenConnection()");
            //connection open logic of SqlServer
        }
        public void CloseConnection()
        {
            Console.WriteLine("CustomMySqlDataBase.CloseConnection()");
            //connection close logic of 
        }
        public void ExecuteQuery(string query)
        {
            Console.WriteLine("CustomMySqlDataBase.ExecuteQuery()");
            //
        }



    }
    
    class CustomerDAL
    {
        private ICustomDatabase database;

        public CustomerDAL(DataBaseTypes type)
        {
            Console.WriteLine("CustomerDAL.CustomerDAL()");

            if (type == DataBaseTypes.SqlDatabase)
                database = new CustomSqlDataBase("connection string for sql server db");
            else if(type == DataBaseTypes.MySqlDatabase)
                database = new CustomMySqlDataBase("connection string for sql server db");
        }
        public void SaveCustomer(String data)
        {
            Console.WriteLine("CustomerDAL.SaveCustomer()");
            database.OpenConnection();
            database.ExecuteQuery("Insert into etc etc");
            database.CloseConnection();
        }
        public void DeleteCustomer( String id)
        {
            Console.WriteLine("CustomerDAL.DeleteCustomer()");
            database.OpenConnection();
            database.ExecuteQuery("delete from etc etc");
            database.CloseConnection();
        }
    }

    enum DataBaseTypes
    {
        SqlDatabase = 1,
        MySqlDatabase = 2
    }
}
