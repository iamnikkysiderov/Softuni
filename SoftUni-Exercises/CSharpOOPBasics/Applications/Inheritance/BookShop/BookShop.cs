using System;

namespace BookShop
{
    class BookShop
    {
        static void Main(string[] args)
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

            try
            {
                GoldenEditionBook book = new GoldenEditionBook(title, author, price);
                Console.WriteLine(book.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
