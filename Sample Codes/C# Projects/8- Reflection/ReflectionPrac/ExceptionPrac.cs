using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionPrac
{
    [Serializable]
    public class CustomDatabaseException : Exception
    {
        public String ConnectionString
        {
            get;
            set;
        }

        public CustomDatabaseException(String pConnectionString)
        {
            this.ConnectionString = pConnectionString;
        }
        public CustomDatabaseException(String message, String pConnectionString)
            : base(message)
        {
            this.ConnectionString = pConnectionString;
        }
        public CustomDatabaseException(String message,String pConnectionString, Exception innerException)
            : base(message, innerException)
        {
            this.ConnectionString = pConnectionString;
        }
    }
    class ExceptionPrac
    {
        public void OpenConnection(String connString)
        {
            throw new CustomDatabaseException("Custom Exception Throwing...",connString);
        }

        public void GetData()
        {
            try
            {
                OpenConnection("Test Connection String");
            }
            catch (CustomDatabaseException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ConnectionString);
            }
        }

    }
}
