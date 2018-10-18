using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            List<string> nameAndCharacteristics = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, string> nameAndPositionPairs = new Dictionary<string, string>();
            Dictionary<string, int> nameAndAgePairs = new Dictionary<string, int>();
            Dictionary<string, double> nameAndSalaryPairs = new Dictionary<string, double>();

            while (nameAndCharacteristics[0] != "filter" && nameAndCharacteristics[1] != "base")
            {
                string name = nameAndCharacteristics[0];
                int age;
                double salary;
                string position;
                string secondElement = nameAndCharacteristics[nameAndCharacteristics.Count - 1];

                bool checkAge = int.TryParse(secondElement, out age);
                bool checkSalary = double.TryParse(secondElement, out salary);

                if (checkAge)
                {
                    nameAndAgePairs[name] = age;
                }
                else if (checkSalary)
                {
                    nameAndSalaryPairs[name] = salary;
                }
                else
                {
                    position = secondElement;

                    nameAndPositionPairs[name] = position;
                }

                nameAndCharacteristics = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            string filterBase = Console.ReadLine();

            if (filterBase == "Age")
            {
                foreach (var kvp in nameAndAgePairs)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (filterBase == "Salary")
            {
                foreach (var kvp in nameAndSalaryPairs)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:f2}");
                    Console.WriteLine("====================");
                }
            }
            else if (filterBase == "Position")
            {
                foreach (var kvp in nameAndPositionPairs)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
