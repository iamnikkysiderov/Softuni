using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gameBarStorage = new Dictionary<string, double>();

            gameBarStorage = GetProductsValues(gameBarStorage);

            Dictionary<string, Dictionary<string, int>> studentOrders = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, double> totalPriceOfEachStudent = new Dictionary<string, double>();

            studentOrders = GetOrdersOfStudents(gameBarStorage, studentOrders, totalPriceOfEachStudent);

            PrintOrders(studentOrders, totalPriceOfEachStudent);
        }
        static Dictionary<string, double> GetProductsValues(Dictionary<string, double> gameBarStorage)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> inputParams = Console.ReadLine().Split('-').ToList();
                string product = inputParams[0];
                double value = double.Parse(inputParams[1]);

                gameBarStorage[product] = value;
            }

            return gameBarStorage;
        }
        static Dictionary<string, Dictionary<string, int>> GetOrdersOfStudents(Dictionary<string, double> gameBarStorage, Dictionary<string,
            Dictionary<string, int>> studentOrders, Dictionary<string, double> totalPriceOfEachStudent)
        {
            string input = Console.ReadLine();

            while (input != "end of clients")
            {
                List<string> inputParams = input.Split(new[] { '-', ',' },StringSplitOptions.RemoveEmptyEntries).ToList();
                string studentName = inputParams[0];
                string buyingProduct = inputParams[1];
                int quantity = int.Parse(inputParams[2]);

                if (gameBarStorage.ContainsKey(buyingProduct))
                {
                    double price = gameBarStorage[buyingProduct] * quantity;

                    if (!studentOrders.ContainsKey(studentName))
                    {
                        studentOrders[studentName] = new Dictionary<string, int>();
                    }
                    if (!studentOrders[studentName].ContainsKey(buyingProduct))
                    {
                        studentOrders[studentName][buyingProduct] = 0;
                    }

                    studentOrders[studentName][buyingProduct] += quantity;

                    if (!totalPriceOfEachStudent.ContainsKey(studentName))
                    {
                        totalPriceOfEachStudent[studentName] = 0;
                    }
                    totalPriceOfEachStudent[studentName] += price;
                }

                input = Console.ReadLine();
            }

            return studentOrders;
        }
        static void PrintOrders(Dictionary<string, Dictionary<string, int>> studentOrders, Dictionary<string, double> totalPriceOfEachStudentOrder)
        {
            foreach (var student in studentOrders.OrderBy(x => x.Key))
            {
                string studentName = student.Key;
                double totalPriceOfCurrentStudentOrder = totalPriceOfEachStudentOrder[studentName];
                Dictionary<string, int> currentStudentOrders = student.Value;

                Console.WriteLine($"{studentName}");

                foreach (var order in currentStudentOrders)
                {
                    string orderedProduct = order.Key;
                    int quantity = order.Value;

                    Console.WriteLine($"-- {orderedProduct} - {quantity}");
                }

                Console.WriteLine($"Bill: {totalPriceOfCurrentStudentOrder:f2}");
            }

            Console.WriteLine($"Total bill: {totalPriceOfEachStudentOrder.Sum(x => x.Value):f2}");
        }
    }
}
