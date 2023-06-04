using PatternModel.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternModel.AccessData
{
    public class EmployeeRegistry
    {
        private static EmployeeRegistry? instance;       

        private EmployeeRegistry() { }

        public static EmployeeRegistry GetInstance()
        {
            if (instance == null)
            {
                instance = new EmployeeRegistry();
            }

            return instance;
        }
        public bool InsertEmployee(Employee employee)
        {
            Console.WriteLine("..........");
            Console.ReadLine();
            return true;
        }

        private bool UpdateEmployee()
        {
            return true;
        }
        private bool DeleteEmployee()
        {
            return true;
        }
    }
}
