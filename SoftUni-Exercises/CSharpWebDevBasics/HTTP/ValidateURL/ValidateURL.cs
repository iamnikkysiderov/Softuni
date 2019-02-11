using System;

namespace ValidateURL
{
    class ValidateURL
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var uriInput = new Uri(input);

            bool invalidScheme = uriInput.Scheme is null || uriInput.Scheme.ToString() == string.Empty;
            bool invalidHost = uriInput.Host is null || uriInput.Host.ToString() == string.Empty;
            bool invalidPort = uriInput.Port.ToString() is null || uriInput.Port.ToString() == string.Empty;
            bool invalidPath = uriInput.AbsolutePath is null || uriInput.AbsolutePath.ToString() == string.Empty;

            if (!invalidScheme)
            {
                if (!invalidHost)
                {
                    if (!invalidPort)
                    {
                        if (!invalidPath)
                        {
                            Console.WriteLine($"Protocol: {uriInput.Scheme}");
                            Console.WriteLine($"Host: {uriInput.Host}");
                            Console.WriteLine($"Port: {uriInput.Port}");
                            Console.WriteLine($"Path: {uriInput.AbsolutePath}");

                            if (!(uriInput.Query == null || uriInput.Query.ToString() == string.Empty))
                            {
                                Console.WriteLine($"Query: {uriInput.Query}");
                            }
                            
                            if (!(uriInput.Fragment == null || uriInput.Fragment.ToString() == string.Empty))
                            {
                                Console.WriteLine($"Fragment: {uriInput.Fragment}");
                            }
                        }
                    }
                }
            }

            if (invalidScheme || invalidHost || invalidPort || invalidPath)
            {
                Console.WriteLine("Invalid URL");
            }
        }
    }
}
