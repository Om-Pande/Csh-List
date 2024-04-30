using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
    
{
   
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetAllEmployees()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<Employee> employees = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployees",con);
                cmd.CommandType= CommandType.StoredProcedure;
                con.Open();
               SqlDataReader rdr =  cmd.ExecuteReader();

                while (rdr.Read())
                {

                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(rdr["Id"]);
                    employee.Name = rdr["Name"].ToString();
                    //employee.Gender = rdr["Gender"].ToString();
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
