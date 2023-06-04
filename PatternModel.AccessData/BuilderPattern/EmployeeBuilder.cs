﻿using PatternModel.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternModel.AccessData.BuilderPattern
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        private Employee employee;

        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        public void SetName(string name)
        {
            employee.Name = name;
        }

        public void SetLastName(string lastName)
        {
            employee.LastName = lastName;
        }

        public void SetIdentification(string identification)
        {
            employee.Identification = identification;
        }

        public void SetPosition(string position)
        {
            employee.Position = position;
        }

        public Employee Build()
        {
            return employee;
        }
    }
}
