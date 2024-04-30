using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLayerBase
    {
        public List<Employee> GetAllEmployees()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;


            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                List<Employee> employees = new List<Employee>();
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(rdr["Id"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.Salary = Convert.ToInt32(rdr["Salary"]);
                    employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                    employee.City = rdr["City"].ToString();

                    employees.Add(employee);

                }
                return employees;
            }
        }
    }
}