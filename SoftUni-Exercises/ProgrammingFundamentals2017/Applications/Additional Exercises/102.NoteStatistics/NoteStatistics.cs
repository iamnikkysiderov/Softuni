using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102.NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<string> naturalNotes = new List<string>();
            List<string> sharpNotes = new List<string>();
            List<string> allNotes = new List<string>();
            List<double> sumOfnaturals = new List<double>();
            List<double> sumOfSharps = new List<double>();
            double naturalsSum = 0.00;
            double sharpsSum = 0;

            foreach (double frequency in frequencies)
            {
                if (frequency == 261.63)
                {
                    sumOfnaturals.Add(frequency);
                    naturalNotes.Add("C");
                    allNotes.Add("C");
                }
                else if (frequency == 277.18)
                {
                    sumOfSharps.Add(frequency);
                    sharpNotes.Add("C#");
                    allNotes.Add("C#");
                }
                else if (frequency == 293.66)
                {
                    sumOfnaturals.Add(frequency);
                    naturalNotes.Add("D");
                    allNotes.Add("D");
                }
                else if (frequency == 311.13)
                {
                    sumOfSharps.Add(frequency);
                    allNotes.Add("D#");
                    sharpNotes.Add("D#");
                }
                else if (frequency == 329.63)
                {
                    sumOfnaturals.Add(frequency);
                    allNotes.Add("E");
                    naturalNotes.Add("E");
                }
                else if (frequency == 349.23)
                {
                    sumOfnaturals.Add(frequency);
                    allNotes.Add("F");
                    naturalNotes.Add("F");
                }
                else if (frequency == 369.99)
                {
                    sumOfSharps.Add(frequency);
                    allNotes.Add("F#");
                    sharpNotes.Add("F#");
                }
                else if (frequency == 392.00)
                {
                    sumOfnaturals.Add(frequency);
                    allNotes.Add("G");
                    naturalNotes.Add("G");
                }
                else if (frequency == 415.30)
                {
                    sumOfSharps.Add(frequency);
                    allNotes.Add("G#");
                    sharpNotes.Add("G#");
                }
                else if (frequency == 440.00)
                {
                    sumOfnaturals.Add(frequency);
                    allNotes.Add("A");
                    naturalNotes.Add("A");
                }
                else if (frequency == 466.16)
                {
                    sumOfSharps.Add(frequency);
                    allNotes.Add("A#");
                    sharpNotes.Add("A#");
                }
                else if (frequency == 493.88)
                {
                    sumOfnaturals.Add(frequency);
                    allNotes.Add("B");
                    naturalNotes.Add("B");
                }
            }

            foreach (double number in sumOfnaturals)
            {
                naturalsSum += number;
            }
            foreach (double number in sumOfSharps)
            {
                sharpsSum += number;
            }

            Console.WriteLine("Notes: {0}",string.Join(" ",allNotes));
            Console.WriteLine("Naturals: {0}",string.Join(", ",naturalNotes));
            Console.WriteLine("Sharps: {0}",string.Join(", ",sharpNotes));
            Console.WriteLine("Naturals sum: {0}",Math.Round(naturalsSum,2));
            Console.WriteLine("Sharps sum: {0}",Math.Round(sharpsSum,2));

        }
    }
}
