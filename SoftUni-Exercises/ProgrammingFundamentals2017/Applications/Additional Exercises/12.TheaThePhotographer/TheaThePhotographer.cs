using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        { //Neprowerena
            int allPics = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double percentOfGoodPhotos = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int filteredPics = (int)Math.Ceiling(allPics * (percentOfGoodPhotos / 100));
            int timeToFilter = allPics * filterTime;
            int timeToUpload = filteredPics * uploadTime;
            int totalTime = timeToFilter + timeToUpload;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            int days = (int)time.TotalDays;
            int hours = (int)time.Hours;
            int minutes = (int)time.Minutes;
            int seconds = (int)time.Seconds;

            Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}",days,hours,minutes,seconds);

            
        }
    }
}
