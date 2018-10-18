using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class CountWorkingDays // 20-12-2015 -> 31-12-2015 my output <9> expected output <7>
    {
        static void Main(string[] args)
        {
            string inputStartDate = Console.ReadLine();
            int year = GetYear(inputStartDate);
            DateTime beginningDate = DateTime.ParseExact(inputStartDate, "dd-MM-yyyy", null);
            string inputEndDate = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(inputEndDate, "dd-MM-yyyy", null);

            int workingDays = 0;
            bool isHoliday = false;
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(year,01,01),
                new DateTime(year,03,03),
                new DateTime(year,05,01),
                new DateTime(year,05,06),
                new DateTime(year,05,24),
                new DateTime(year,07,06),
                new DateTime(year,11,01),
                new DateTime(year,12,24),
                new DateTime(year,12,25),
                new DateTime(year,12,26)
            };

            for (DateTime currentDay = beginningDate; currentDay <= endDate; currentDay = currentDay.AddDays(1))
            {
                isHoliday = false;

                if (currentDay.DayOfWeek != DayOfWeek.Saturday || currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (currentDay == holidays[i])
                        {
                            isHoliday = true;
                        }
                    }

                    if (isHoliday == false)
                    {
                        workingDays++;
                    }
                }
            }

            Console.WriteLine(workingDays);
        }
        static int GetYear(string inputStartDate)
        {
            List<string> list = inputStartDate.Split('-').ToList();

            return int.Parse(list[2]);
        }
    }
} 
