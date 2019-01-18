using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Weekly salary should be more than 10!");
                }

                weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 1 && value > 12)
                {
                    throw new ArgumentException("Invalid working hours per day!");
                }

                workHoursPerDay = value;
            }
        }

        public decimal SalaryPerHour
        {
            get { return WeekSalary / WorkHoursPerDay/ 5; }
        }

        public override string ToString()
        {
            return $"First name: {FirstName}\nLast name: {LastName}\nWeekly salary: {WeekSalary:f2}\nWork hours per day: {WorkHoursPerDay:f2}\nSalary per hour: {SalaryPerHour:f2}";
        }
    }
}
