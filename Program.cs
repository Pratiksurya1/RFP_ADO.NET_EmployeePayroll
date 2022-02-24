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

            //  dbHandler.Select();

            //  dbHandler.Update("'rohit'");
            //  dbHandler.selectByDate("'2010-11-05'", "'2021-12-09'");

            dbHandler.ArithmeticOperations();

            EmpDataSet emp = new EmpDataSet();

            emp.name = "prtap";
            emp.gender = 'M';
            emp.basic_pay = 15422;
            emp.deductions = 4522;
            emp.taxable_pay = 455;
            emp.incometax = 556;
            emp.net_pay = 45;
            dbHandler.Insert(emp);
        }
    }
}