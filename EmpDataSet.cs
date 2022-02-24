using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_EmployeePayroll
{
    public class EmpDataSet
    {
        public String name { get; set; }
        public int salary { get; set; }
        public DateOnly start_date { get; set; }
        public char gender { get; set; }
        public int basic_pay { get; set; }
        public int deductions { get; set; }
        public int taxable_pay { get; set; }
        public int incometax { get; set; }
        public int net_pay { get; set; }

    }
}
