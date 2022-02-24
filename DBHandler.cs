using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_EmployeePayroll
{
    internal class DBHandler: DBConnecter
    {
        public DataSet CheckConnection()
        {
            SqlConnection connection = GetConnection();
            try
            {
                DataSet dataset = new DataSet();
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM employee_payroll",connection);
                    adapter.Fill(dataset);
                    connection.Close();
                    return dataset;
                }
            }catch (Exception ex)
            {
                return null;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close ();
            }
        }
    }
}
