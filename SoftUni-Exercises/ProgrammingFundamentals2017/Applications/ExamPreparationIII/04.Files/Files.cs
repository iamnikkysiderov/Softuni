using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, string> filesWithExtension = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> filePath = Console.ReadLine().Split('\\').ToList();
                string root = filePath[0];
                List<string> fileParams = filePath[filePath.Count - 1].Split(';').ToList();
                string fileNameWithExtension = fileParams[0];
                long fileSize = long.Parse(fileParams[1]);

                string fileName = fileNameWithExtension;
                string fileExtension = fileNameWithExtension.Split('.')[fileNameWithExtension.Split('.').Length-1];

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot[root] = new Dictionary<string, long>();
                }

                filesByRoot[root][fileName] = fileSize;
                filesWithExtension[fileName] = fileExtension;
            }

            List<string> query = Console.ReadLine().Split(' ').ToList();
            string queryExtension = query[0];
            string queryRoot = query[2];

            Dictionary<string, long> extractedFiles = new Dictionary<string, long>();

            if (filesByRoot.ContainsKey(queryRoot))
            {
                foreach (var file in filesByRoot[queryRoot])
                {
                    if (filesWithExtension[file.Key] == queryExtension)
                    {
                        extractedFiles.Add(file.Key, file.Value);
                    }
                }
            }

            if (extractedFiles.Count > 0)
            {
                foreach (var file in extractedFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
