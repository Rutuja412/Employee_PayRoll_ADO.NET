using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayroll_ADO.Net
{
    public class EmployeeRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Emp_Payroll;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}
