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

        public override void Select()
        {
            SqlConnection connection = GetConnection();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM employee_payroll", connection);
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
