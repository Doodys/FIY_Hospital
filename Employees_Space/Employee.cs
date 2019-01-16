using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Employees_Space
{
    public class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public string PWD { get; set; }
        public string Specialization { get; set; }

        public static void _Convert()
        {
            string filePath = Environment.CurrentDirectory;
            string extension = ".csv";
            filePath += @"\Employees" + extension;
            List<Employee> EmployeesData = File.ReadAllLines(filePath)
                                           .Skip(1)
                                           .Select(v => FromCsv(v))
                                           .ToList();
        }

        public static Employee FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Employee insertData = new Employee();
            insertData.Username = values[0];
            insertData.Password = values[1];
            insertData.Role = values[2];
            insertData.Name = values[3];
            insertData.Surname = values[4];
            insertData.Pesel = values[5];
            insertData.PWD = values[6];
            insertData.Specialization = values[7];
            return insertData;
        }
    }
}
