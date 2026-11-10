using AssetTracker.Models;
using MySql.Data.MySqlClient;
using System;
namespace AssetTracker.Data;
    public class EmployeeRepository
    {
        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();
            string sql = "SELECT employee_id, first_name, last_name, email_address FROM employee ORDER BY last_name";

            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EmployeeId = reader.GetInt32("employee_id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            EmailAddress = reader.GetString("email_address")
                        });
                    }
                }
            }
            return employees;
        }
    }
