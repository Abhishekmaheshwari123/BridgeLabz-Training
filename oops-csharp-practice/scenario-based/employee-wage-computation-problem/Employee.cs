using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    internal class Employee
    {
        private int employeeId;
        private string employeeName;
        private int employeeAge;
        private double employeeSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public int EmployeeAge
        {
            get { return employeeAge; }
            set { employeeAge = value; }
        }

        public double EmployeeSalary
        {
            get { return employeeSalary; }
            set { employeeSalary = value; }
        }

        // Constants for wage calculation
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOUR = 8;
        public const int PART_TIME_HOUR = 4;
        public const int WORKING_DAYS_PER_MONTH = 20;
        public const int MAX_WORKING_HOURS = 100;
        public const int MAX_WORKING_DAYS = 20;

        // Attendance constants
        public const int IS_PRESENT = 1;
        public const int IS_ABSENT = 0;
        public const int IS_PART_TIME = 2;


        public override string? ToString()
        {
            return "Employee Id " + employeeId +
                "\nEmployee Name " + employeeName +
                "\nEmployee Age " + employeeAge +
                "\nEmployee Salary " + employeeSalary;
        }
    }
}