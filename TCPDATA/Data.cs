using System;
using System.Collections.Generic;

namespace TCPDATA
{
	public class Data
	{
		public static class Data
		{
			public static List<Employee> GetEmployee()
			{
				List<Employee> employees = new List<Employee>();
				Employee employee = new Employee
				{
					Id = 1,
					FirstName = "Bob",
					LastName = "Jones",
					AnnualSalary = 60000.3m,
					IsManager = true,
					DepartmentId = 1
				};employees.Add(employee);
				employee = new Employee
				{
					Id = 2,
					FirstName = "Sarah",
					LastName = "Jameson",
					AnnualSalary = 80000.1m,
					IsManager = true,
					DepartmentId = 2
                }; employees.Add(employee);
                employee = new Employee
                {
                    Id = 3,
                    FirstName = "Douglas",
                    LastName = "Robers",
                    AnnualSalary = 40000.1m,
                    IsManager = false,
                    DepartmentId = 2
                }; employees.Add(employee);
                employee = new Employee
                {
                    Id = 4,
                    FirstName = "Jane",
                    LastName = "Stevens",
                    AnnualSalary = 30000.1m,
                    IsManager = false,
                    DepartmentId = 3
                }; employees.Add(employee);
				return employees;
            }
			public static List<Department> GetDepartments()
			{

			}
		}
	}
}

