using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_EmployeePayroll
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("****************** WELLCOME ******************");

            DBHandler dbHandler = new DBHandler();  
            if(dbHandler.CheckConnection() != null)
            {
                Console.WriteLine("Connection Succeed");
            }
            else
            {
                Console.WriteLine("Connection failed");
            }
        }
    }
}