using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.employee_wage_computation_problem
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        private Random random;

        public EmployeeUtilityImpl()
        {
            random = new Random();
        }

        // Logic
        public Employee AddEmployee()
        {
            employee = new Employee();

            Console.Write("Enter Employee ID: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            employee.EmployeeAge = int.Parse(Console.ReadLine());

            employee.EmployeeSalary = 0; // Will be calculated based on attendance

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine(employee.ToString());

            return employee;
        }

        // UC1 - Check Employee is Present or Absent
        public bool CheckEmployeeAttendance()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add an employee first!");
                return false;
            }

            int attendance = random.Next(0, 2); // Generates 0 or 1
            if (attendance == Employee.IS_PRESENT)
            {
                Console.WriteLine($"Employee {employee.EmployeeName} (ID: {employee.EmployeeId}) is Present");
                return true;
            }
            else
            {
                Console.WriteLine($"Employee {employee.EmployeeName} (ID: {employee.EmployeeId}) is Absent");
                return false;
            }
        }

        // UC2 - Calculate Daily Employee Wage
        public double CalculateDailyWage()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add an employee first!");
                return 0;
            }

            bool isPresent = CheckEmployeeAttendance();
            double dailyWage = 0;

            if (isPresent)
            {
                dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                Console.WriteLine($"Daily Wage for {employee.EmployeeName}: {dailyWage}");
            }
            else
            {
                Console.WriteLine($"Daily Wage for {employee.EmployeeName}: 0 (Employee Absent)");
            }

            return dailyWage;
        }

        // UC3 - Add Part Time Employee & Wage
        public double CalculatePartTimeWage()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add an employee first!");
                return 0;
            }

            double wage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
            Console.WriteLine($"Part Time Wage for {employee.EmployeeName}: {wage}");
            return wage;
        }

        // UC4 - Solving using Switch Case Statement
        public double CalculateWageUsingSwitchCase()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add an employee first!");
                return 0;
            }

            int empType = random.Next(0, 3); // 0: Absent, 1: Full Time, 2: Part Time
            double dailyWage = 0;

            switch (empType)
            {
                case Employee.IS_ABSENT:
                    Console.WriteLine($"{employee.EmployeeName} is Absent");
                    dailyWage = 0;
                    break;
                case Employee.IS_PRESENT:
                    Console.WriteLine($"{employee.EmployeeName} is Present (Full Time)");
                    dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                    break;
                case Employee.IS_PART_TIME:
                    Console.WriteLine($"{employee.EmployeeName} is Present (Part Time)");
                    dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                    break;
                default:
                    Console.WriteLine("Invalid Employee Type");
                    break;
            }

            Console.WriteLine($"Daily Wage for {employee.EmployeeName}: {dailyWage}");
            return dailyWage;
        }

        // UC5 - Calculating Wages for a Month
        public double CalculateMonthlyWage()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add an employee first!");
                return 0;
            }

            double monthlyWage = 0;

            Console.WriteLine($"\n--- Monthly Wage Calculation for {employee.EmployeeName} (ID: {employee.EmployeeId}) ---");

            for (int day = 1; day <= Employee.WORKING_DAYS_PER_MONTH; day++)
            {
                int empType = random.Next(0, 3);
                double dailyWage = 0;

                switch (empType)
                {
                    case Employee.IS_ABSENT:
                        dailyWage = 0;
                        break;
                    case Employee.IS_PRESENT:
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                        break;
                    case Employee.IS_PART_TIME:
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                        break;
                }

                monthlyWage += dailyWage;
                Console.WriteLine($"Day {day}: Wage = {dailyWage}");
            }

            employee.EmployeeSalary = monthlyWage;
            Console.WriteLine($"\nTotal Monthly Wage for {employee.EmployeeName}: {monthlyWage}");
            Console.WriteLine("\nUpdated Employee Details:");
            Console.WriteLine(employee.ToString());

            return monthlyWage;
        }

        // UC6 - Calculate Wages till a condition of total working hours or days is reached
        public double CalculateWageTillCondition()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add an employee first!");
                return 0;
            }

            int totalWorkingHours = 0;
            int totalWorkingDays = 0;
            double totalWage = 0;

            Console.WriteLine($"\n--- Wage Calculation Till Condition for {employee.EmployeeName} (ID: {employee.EmployeeId}) ---");
            Console.WriteLine($"Max Hours: {Employee.MAX_WORKING_HOURS}, Max Days: {Employee.MAX_WORKING_DAYS}");

            while (totalWorkingHours < Employee.MAX_WORKING_HOURS && totalWorkingDays < Employee.MAX_WORKING_DAYS)
            {
                totalWorkingDays++;
                int empType = random.Next(0, 3);
                int hoursWorked = 0;
                double dailyWage = 0;

                switch (empType)
                {
                    case Employee.IS_ABSENT:
                        hoursWorked = 0;
                        dailyWage = 0;
                        break;
                    case Employee.IS_PRESENT:
                        hoursWorked = Employee.FULL_DAY_HOUR;
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
                        break;
                    case Employee.IS_PART_TIME:
                        hoursWorked = Employee.PART_TIME_HOUR;
                        dailyWage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
                        break;
                }

                totalWorkingHours += hoursWorked;
                totalWage += dailyWage;

                Console.WriteLine($"Day {totalWorkingDays}: Hours = {hoursWorked}, Wage = {dailyWage}, Total Hours = {totalWorkingHours}");
            }

            employee.EmployeeSalary = totalWage;

            Console.WriteLine($"\n--- Summary for {employee.EmployeeName} ---");
            Console.WriteLine($"Total Working Days: {totalWorkingDays}");
            Console.WriteLine($"Total Working Hours: {totalWorkingHours}");
            Console.WriteLine($"Total Wage: {totalWage}");
            Console.WriteLine("\nUpdated Employee Details:");
            Console.WriteLine(employee.ToString());

            return totalWage;
        }
    }
}