
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

            //var employeelist = employeelist.Select(e => new
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
            //var result = from dept in departmentlist
            //             join emp in employeelist
            //             on dept.Id equals emp.DepartmentId
            //             into employeeGroup
            //             select new
            //             {
            //                 Employees = employeeGroup,
            //                 DepartmentName = dept.LongName
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Department Name: {item.DepartmentName}");
            //    foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //    }

            //}


            ///// ALL, Any, Contains Quantifier Operator
            //var annualSalaryCompare = 100000;

            //bool isTrueAll = employeelist.All(e => e.AnnualSalary > annualSalaryCompare);

            //if (isTrueAll)
            //{
            //    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Not all employees's annual salary is above {annualSalaryCompare}");
            //}


            //bool isTrueAny = employeelist.Any(e => e.AnnualSalary > annualSalaryCompare);

            //if (isTrueAny)
            //{
            //    Console.WriteLine($"Some of the employees annual salary is above {annualSalaryCompare}");

            //}
            //else
            //{
            //    Console.WriteLine($"None of the employee's annual salary is above {annualSalaryCompare}");
            //}


            ///// CONTAINS key work operator
            //var searchEmployee = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Robers",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 1
            //};
            //bool containsEmployee = employeelist.Contains(searchEmployee, new EmployeeComparer());

            //if (containsEmployee)
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            //}
            //else
            //{
            //    Console.WriteLine($"An employee for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");
            //}



            ///OfType Filter Operator
            //ArrayList mixedCollection = Data.GetHeterogeneousDataCollection();

            //var stringResult = from s in mixedCollection.OfType<string>()
            //                   select s;

            //foreach (var item in stringResult)
            //    Console.WriteLine(item);


            ///Element At or Element at by Default
            //var emp = employeelist.ElementAtOrDefault(12);

            //if (emp != null)
            //{
            //    Console.WriteLine($"{emp.FirstName,-10}{emp.LastName,-10}");
            //}
            //else
            //{
            //    Console.WriteLine("This employee does not exist in this collection");
            //}



            /////
            //List<int> integerList = new List<int> { 3, 14, 23, 17, 27, 89 };

            //int result = integerList.FirstOrDefault(i => i % 2 == 0);
            //if (result != 0)
            //{

            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("There are no even numbers in the Collection");
            //}

            ///Single Operator
            //var emp = employeelist.Single(e => e.Id == 2);
            //Console.WriteLine($" {emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");


            //Equality Operator
            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            //var boolSequenceEqual = integerList1.SequenceEqual(integerList2);
            //Console.WriteLine(boolSequenceEqual);



            ////Concat
            //List<Employee> employeelist2 = new List<Employee> { new Employee
            //{
            //    Id = 5,
            //    FirstName = "Tony",
            //    LastName = "Garcia",
            //    AnnualSalary = 90000,

            //}, new Employee
            //{
            //    Id = 6,
            //    FirstName = "Tony",
            //    LastName = "Garcia",
            //    AnnualSalary = 90000,

            //}
            //};
            //IEnumerable<Employee> results = employeelist.Concat(employeelist2);

            //foreach(var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName,-10}");

            //}


            ///AGGREGAT
            //decimal totalAnnualSalary = employeelist.Aggregate<Employee, decimal>(0, (totalAnnualSalary, e) =>
            //{
            //    var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //    totalAnnualSalary = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totalAnnualSalary;
            //    return totalAnnualSalary;
            //});
            //Console.WriteLine($"Total Annual Salary of all employees (including bonus): {totalAnnualSalary}");


            ///COUNT
            //int countEmployees = employeelist.Count(e => e.DepartmentId == 2);
            //Console.WriteLine($"Number of Employee (Finance Department): {countEmployees}");

            //SUM
            //decimal result = employeelist.Sum(e => e.AnnualSalary);
            //Console.WriteLine($"Total Annual Salary: {result}");

            ////MAX
            //var results = employeelist.Max(e => e.AnnualSalary);
            //Console.WriteLine($"Max Salary: {results}");

            ////Generation Operators - DefaultIfEmpty, Empty, Range, Repeat
            //DefaultIfEmpty
            //List<int> intList = new List<int>();
            //var newList = intList.DefaultIfEmpty();

            //Console.WriteLine(newList.ElementAt(0));

            //List<Employee> employees = new List<Employee>();
            //var newList = employees.DefaultIfEmpty(new Employee { Id = 0 });

            //var result = newList.ElementAt(0);

            //if (result.Id == 0)
            //    Console.WriteLine($"The list is empty");

            ////Empty
            //List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();

            //emptyEmployeeList.Add(new Employee { Id = 7, FirstName = "Dan", LastName = "Brown" });

            //foreach (var item in emptyEmployeeList)
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");

            ////Range
            //var intCollection = Enumerable.Range(25, 20);
            //foreach (var item in intCollection)
            //    Console.WriteLine(item);

            ////Repeat
            //var strCollection = Enumerable.Repeat<string>("Placeholder", 10);
            //foreach (var item in strCollection)
            //    Console.WriteLine(item);

            ////Set Operators - Distinct, Except, Intersect, Union
            ////Distinct

            //List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
            //var results = list.Distinct();
            //foreach (var item in results)
            //    Console.WriteLine(item);

            ////Except

            //IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
            //IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6 };

            //var results = collection2.Except(collection1);
            //foreach (var item in results)
            //    Console.WriteLine(item);

            //List<Employee> employeeList2 = new List<Employee>();

            //employeeList2.Add(new Employee
            //    {
            //        Id = 1,
            //        FirstName = "Bob",
            //        LastName = "Jones",
            //        AnnualSalary = 60000.3m,
            //        IsManager = true,
            //        DepartmentId = 2
            //    }
            //);
            //employeeList2.Add(new Employee
            //    {
            //        Id = 3,
            //        FirstName = "Douglas",
            //        LastName = "Roberts",
            //        AnnualSalary = 40000.2m,
            //        IsManager = false,
            //        DepartmentId = 1
            //    }
            //);
            //employeeList2.Add(new Employee
            //    {
            //        Id = 5,
            //        FirstName = "Craig",
            //        LastName = "Laurence",
            //        AnnualSalary = 20000.2m,
            //        IsManager = false,
            //        DepartmentId = 1
            //    }
            //);
            //employeeList2.Add(new Employee
            //    {
            //        Id = 6,
            //        FirstName = "Elizabeth",
            //        LastName = "Tate",
            //        AnnualSalary = 85000,
            //        IsManager = true,
            //        DepartmentId = 1
            //    }
            //);

            //var results = employeeList.Except(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Intersect
            //var results = employeeList.Intersect(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Union
            //var results = employeeList.Union(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Partitioning Operators - Skip, SkipWhile, Take, TakeWhile
            ////Skip

            //var results = employeeList.Skip(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////SkipWhile

            //employeeList.Add(new Employee { Id = 5, FirstName = "Sam", LastName = "Davis", AnnualSalary = 100000.0m });

            //var results = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Take
            //var results = employeeList.Take(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////TakeWhile

            //employeeList.Add(new Employee { Id = 5, FirstName = "Sam", LastName = "Davis", AnnualSalary = 100000 });

            //var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Conversion Operators - ToList, ToDictionary, ToArray
            ////ToList

            //List<Employee> results = (from emp in employeeList
            //                         where emp.AnnualSalary > 50000
            //                         select emp).ToList();

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////ToDictionary

            //Dictionary<int, Employee> dictionary = (from emp in employeeList
            //                                        where emp.AnnualSalary > 50000
            //                                        select emp).ToDictionary<Employee, int>(e => e.Id);

            //foreach (var key in dictionary.Keys)
            //    Console.WriteLine($"Key: {key}, Value: {dictionary[key].FirstName} {dictionary[key].LastName}");

            ////ToArray
            //Employee[] results = (from emp in employeeList
            //                      where emp.AnnualSalary > 50000
            //                      select emp).ToArray();

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Let Clause and Into Clause

            ////Let
            //var results = from emp in employeeList
            //              let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
            //              let AnnualSalaryPlusBonus = (emp.IsManager) ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : emp.AnnualSalary + (emp.AnnualSalary * 0.02m)
            //              where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 50000
            //              select new
            //              {
            //                  Initials = Initials,
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalaryPlusBonus = AnnualSalaryPlusBonus
            //              };

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Initials,-5} {item.FullName,-20} {item.AnnualSalaryPlusBonus,10}");

            ////Into
            //var results = from emp in employeeList
            //              where emp.AnnualSalary > 50000
            //              select emp
            //              into HighEarners
            //              where HighEarners.IsManager == true
            //              select HighEarners;

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");

            ////Projection Operators - Select, SelectMany
            ////Select
            //var results = departmentList.Select(d => d.Employees);

            //foreach(var items in results)
            //    foreach(var item in items)
            //        Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");

            ////SelectMany
            //var results = departmentList.SelectMany(d => d.Employees); //.OrderBy(o => o.Id);

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");


            Console.ReadKey();
        }

    }

    //Employee Comparer class

    //public class EmployeeComparer : IEqualityComparer<Employee>
    //{
    //    public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
    //    {
    //        if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public int GetHashCode([DisallowNull] Employee obj)
    //    {
    //        return obj.Id.GetHashCode();
    //    }
    //}


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

       //public static ArrayList GetHeterogeneousDataCollection()
       // {
       //     ArrayList arrayList = new ArrayList();
       //     arrayList.Add(100);
       //     arrayList.Add("Bob Jones");
       //     arrayList.Add(2000);
       //     arrayList.Add(3000);
       //     arrayList.Add("Bill Henderson");
       //     arrayList.Add(new Employee { Id = 6, FirstName = "Jennifer", LastName = "Dale", AnnualSalary = 90000, IsManager = false,
       //     DepartmentId = 3});
       //     arrayList.Add(new Employee { Id = 6, FirstName = "Dane", LastName = "Huges", AnnualSalary = 60000, IsManager = true,
       //     DepartmentId = 4});
       //     arrayList.Add(new Department { Id = 4, ShortName = "MKT", LongName = "Marketing"});
       //     arrayList.Add(new Department { Id = 5, ShortName = "R&D", LongName = "Research and Development" });
       //     arrayList.Add(new Department { Id = 6, ShortName = "PRD", LongName = "Production" });

       //     return arrayList;
       // }

    }
}