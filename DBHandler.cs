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

        public override void Update(String name)
        {
            SqlConnection connection = GetConnection();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("UPDATE employee_payroll SET basic_pay=300000 where name=" + name, connection);
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    int a = command.ExecuteNonQuery();
                    if (a != 0)
                    {
                        Console.WriteLine("Update Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Not Updated");
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

        public override void selectByDate(string start, string end)
        {
            SqlConnection connection = GetConnection();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("SELECT * from employee_payroll where start_date between " + start + " and " + end, connection);
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

        public override void ArithmeticOperations()
        {
            SqlConnection connection = GetConnection();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("SELECT gender, SUM(basic_pay) AS sum, AVG(basic_pay) AS avg, MAX(basic_pay) AS max,MIN(basic_pay) AS min,COUNT(basic_pay) AS count FROM employee_payroll GROUP BY gender", connection);
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    SqlDataReader reader1 = command.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            Console.WriteLine("Ans is : " + reader1[0].ToString() + "\t\t" + reader1[1].ToString() + "\t\t" + reader1[2].ToString() + "\t\t" + reader1[3].ToString() + "\t\t" + reader1[4].ToString() + "\t\t" + reader1[5].ToString());
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
