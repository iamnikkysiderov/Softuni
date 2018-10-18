using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93.TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            List<string> songsToAvoid = Console.ReadLine().Split(' ').ToList();
            string songs = Console.ReadLine();
            List<string> container = new List<string>();
            int counter = 0;

            while (songs != "end")
            {
                for (int i = 0; i < songsToAvoid.Count; i++)
                {
                    if (!(songs.Contains(songsToAvoid[i])))
                    {
                        counter++;
                    }

                    if (counter == songsToAvoid.Count)
                    {
                        container.Add(songs);
                    }
                }

                counter = 0;
                songs = Console.ReadLine();
            }

            container.Sort();

            for (int i = 0; i < container.Count; i++)
            {
                Console.WriteLine(container[i]);
            }
        }
    }
}
