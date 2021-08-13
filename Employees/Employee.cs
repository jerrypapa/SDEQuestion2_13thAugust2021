﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
   public class Employee
    {
        public string Id { get; set; }
        public string ManagerId { get; set; }
        public int Salary { get; set; }
        private Employee() { }
        private Employee(string id, string managerId, int salary)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id));
            if (salary < 0) throw new ArgumentOutOfRangeException(nameof(salary));
            Id = id;
            ManagerId = managerId;
            Salary = salary;
        }
        public static Employee AddNewEmployee(string id, string managerId, int salary)
        {
            return new Employee(id, managerId, salary);
        }
    }
}
