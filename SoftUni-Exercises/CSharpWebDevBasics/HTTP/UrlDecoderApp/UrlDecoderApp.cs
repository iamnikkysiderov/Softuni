using System;
using System.Net;

namespace UrlDecoderApp
{
    class UrlDecoderApp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var decodedInput = WebUtility.UrlDecode(input);

            Console.WriteLine(decodedInput);
        }
    }
}
