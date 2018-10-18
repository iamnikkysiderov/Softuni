using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random randomMessageGenerator = new Random();
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracle. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] city = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", phrases[randomMessageGenerator.Next(0, phrases.Length)]);
                Console.Write("{0} ", events[randomMessageGenerator.Next(0, events.Length)]);
                Console.Write("{0} - ", authors[randomMessageGenerator.Next(0,authors.Length)]);
                Console.Write("{0}", city[randomMessageGenerator.Next(0, city.Length)]);
                Console.WriteLine();
            }
        }
    }
}
