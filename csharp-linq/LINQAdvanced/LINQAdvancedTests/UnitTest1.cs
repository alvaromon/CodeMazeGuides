using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQAdvancedTests
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void TestMethod1()
        {
            var employeeDepartmentGroups = Employee.employees.GroupBy(x => x.Department);
            foreach (var group in employeeDepartmentGroups)
            {
                System.Console.WriteLine("Department - " + group.Key);
                foreach (var employee in group)
                {
                    System.Console.WriteLine(employee.Name);
                }
            }
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public double Salary { get; set; } = 0.0;

        public static List<Employee> employees = new List<Employee>()
        {
            new() { EmployeeId = 1, Name = "Alvin Johnston", Department = "Sales", Salary = 55000.00 },
            new() { EmployeeId = 2, Name = "Jessica Cuevas", Department = "Engineering", Salary = 65000.00 },
            new() { EmployeeId = 3, Name = "Grace Silver", Department = "Sales", Salary = 75000.00 },
            new() { EmployeeId = 4, Name = "Justin Vilches", Department = "Engineering", Salary = 85000.00 },
            new() { EmployeeId = 5, Name = "Joey Delgado", Department = "IT", Salary = 85000.00 },
            new() { EmployeeId = 6, Name = "Ashley Montoya", Department = "Engineering", Salary = 85000.00 },
            new() { EmployeeId = 7, Name = "Silvio Mora", Department = "IT", Salary = 85000.00 },
            new() { EmployeeId = 8, Name = "Arjen Robben", Department = "Administration", Salary = 105000.00 },
            new() { EmployeeId = 9, Name = "Mohammad Salah", Department = "Administration", Salary = 115000.00 },
            new() { EmployeeId = 10, Name = "Nasir Jones", Department = "Customer Service", Salary = 45000.00 },
        };
    }
}