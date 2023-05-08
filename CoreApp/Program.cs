
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApp
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Employee> employeelist = Data.GetEmployees();
            List<Department> departmentlist = Data.GetDepartments();


            //Select and where operator - Method Syntax

            //var result = employeelist.Select(e => new
            //{
            //    FullName = e.FirstName + " " + e.LastName,
            //    AnnualSalary = e.AnnualSalary
            //}).Where(e => e.AnnualSalary >= 50000);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}

            // Select and where operator - Query Syntax
            //var result = from emp in employeelist
            //             where emp.AnnualSalary >= 50000
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary
            //              };
            //employeelist.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2

            //});


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}

            //DEFERRED Execution Example
            //var result = from emp in employeelist.GetHighSalariedEmployees()
            //             select new
            //             {
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 AnnualSalary = emp.AnnualSalary

            //             };
            //employeelist.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}


            // IMMEDIATE Execution Example (just add ToList, ToArray, or ToDictionary)
            //var result = (from emp in employeelist.GetHighSalariedEmployees()
            //             select new
            //             {
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 AnnualSalary = emp.AnnualSalary

            //             }).ToList();
            //employeelist.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}


            //Method Syntax for JOIN
            //var result = departmentlist.Join(employeelist,
            //    department => department.Id,
            //    employee => employee.DepartmentId,
            //    (department, employee) => new
            //    {
            //        FullName = employee.FirstName + " " + employee.LastName,
            //        AnnualSalary = employee.AnnualSalary,
            //        DepartmentName = department.LongName
            //    }
            //    );

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}/t{item.DepartmentName}");
            //}


            //QUERY Syntax for JOIN
            //var result = from dept in departmentlist
            //             join emp in employeelist
            //             on dept.Id equals emp.DepartmentId
            //             select new
            //             {
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 AnnualSalary = emp.AnnualSalary,
            //                 DepartmentName = dept.LongName
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}/t{item.DepartmentName}");

            //}

            //Method Syntax with GROUPJOIN
            //var result = departmentlist.GroupJoin(employeelist,
            //    dept => dept.Id,
            //    emp => emp.DepartmentId,
            //    (dept, employeesGroup) => new
            //    {
            //        Employees = employeesGroup,
            //        DepartmentName = dept.LongName
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Department Name: {item.DepartmentName}");
            //    foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //    }

            //}

            //QUERY Syntax with GROUPJOIN and Order by 
            var result = from dept in departmentlist
                         join emp in employeelist
                         on dept.Id equals emp.DepartmentId
                         into employeeGroup
                         select new
                         {
                             Employees = employeeGroup,
                             DepartmentName = dept.LongName
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"Department Name: {item.DepartmentName}");
                foreach (var emp in item.Employees)
                {
                    Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
                }

            }



            Console.ReadKey();
        }

    }

    public static class EnumberableCollectionExtensionMethods
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Accessing employee: {emp.FirstName + " " + emp.LastName}");
                if (emp.AnnualSalary >= 50000)
                    yield return emp;
            }

        }
    }

    public class Employee
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }

    }

    public static class Data
    {
        public static List<Employee> GetEmployees()
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
            }; employees.Add(employee);
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
            List<Department> departments = new List<Department>();
            Department department = new Department

            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources",

            }; departments.Add(department);
            department = new Department
            {
                Id = 1,
                ShortName = "FN",
                LongName = "Finance",

            }; departments.Add(department);
            department = new Department
            {
                Id = 1,
                ShortName = "TE",
                LongName = "Technology",

            }; departments.Add(department);
            return departments;

        }

    }
}