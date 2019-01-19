using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Reflection;

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

        public static List<Employee> EmployeesData;
        public static string[] HeadersEmployee = { "Name", "Surname", "PWD", "Specialization" }; //3, 4, 6, 7
        public static string[] HeadersAdmin = { "Username", "Password",  "Name", "Surname", "Pesel", "PWD", "Specialization" }; //0, 1, 3, 4, 5, 6, 7
        public static string[] HeadersAdminCheck = {"ID", "Username", "Password", "Name", "Surname", "Pesel", "PWD", "Specialization" }; //0, 1, 3, 4, 5, 6, 7

        public static void _Convert()
        {
            string filePath = Environment.CurrentDirectory;
            string extension = ".csv";
            filePath += @"\Employees" + extension;
            EmployeesData = File.ReadAllLines(filePath)
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

    public class LoginData
    {
        public static bool CheckLoginData(string login, string pass)
        {
            int index1 = Employee.EmployeesData.FindIndex(a => a.Username == login);
            int index2 = Employee.EmployeesData.FindIndex(a => a.Password == pass);

            if (index1 == -1) { index1 = -2; }

            if (index1 == index2) { return true; }
            else { return false; }
        }

        public static string Role(string login)
        {
            int index = Employee.EmployeesData.FindIndex(a => a.Username == login);
            string Role = Employee.EmployeesData[index].Role;

            return Role;
        }
    }

    public class SaveToCsv
    {
        public static void ExportCsv<Employee>(List<Employee> EmployeesData)
        {
            string fileName = "Employees";
            var sb = new StringBuilder();
            string filePath = Environment.CurrentDirectory;
            var finalPath = Path.Combine(filePath, fileName + ".csv");

            if (File.Exists(finalPath)) { File.Delete(finalPath); }

            var header = "";
            var info = typeof(Employee).GetProperties();
            if (!File.Exists(finalPath))
            {
                var file = File.Create(finalPath);
                file.Close();
                foreach (var prop in typeof(Employee).GetProperties())
                {
                    header += prop.Name + ",";
                }
                header = header.Substring(0, header.Length - 2);
                sb.AppendLine(header);
                TextWriter sw = new StreamWriter(finalPath, true);
                sw.Write(sb.ToString());
                sw.Close();
            }
            foreach (var obj in EmployeesData)
            {
                sb = new StringBuilder();
                var line = "";
                foreach (var prop in info)
                {
                    line += prop.GetValue(obj, null) + ",";
                }
                line = line.Substring(0, line.Length - 2);
                sb.AppendLine(line);
                TextWriter sw = new StreamWriter(finalPath, true);
                sw.Write(sb.ToString());
                sw.Close();
            }
        }
    }

    public static class Validator
    {
        private static readonly int[] multipliers = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        public static bool ValidatePesel(string pesel)
        {
            bool toRet = false;
            try
            {
                if (pesel.Length == 11)
                {
                    toRet = CountSum(pesel).Equals(pesel[10].ToString());
                }
            }
            catch (Exception)
            {
                toRet = false;
            }
            return toRet;
        }

        private static string CountSum(string pesel)
        {
            int sum = 0;
            for (int i = 0; i < multipliers.Length; i++)
            {
                sum += multipliers[i] * int.Parse(pesel[i].ToString());
            }

            int rest = sum % 10;
            return rest == 0 ? rest.ToString() : (10 - rest).ToString();
        }

        public static bool UpperOrLower(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            return char.IsUpper(word[0]) ? true : false;
        }
    }
}
