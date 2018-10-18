using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138.ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, HashSet<string>> dictTopicsAndTags = new Dictionary<string, HashSet<string>>();

            while (input[0] != "filter")
            {
                string topic = input[0];

                List<string> tagsOfCurrentTopic = FormatSeparation(input);
                
                if (!dictTopicsAndTags.ContainsKey(topic))
                {
                    dictTopicsAndTags[topic] = new HashSet<string>();
                }

                dictTopicsAndTags = AddTagsToCurrentTopic(dictTopicsAndTags, topic, tagsOfCurrentTopic);

                input = Console.ReadLine().Split(' ').ToList();
            }

            List<string> secondInput = Console.ReadLine().Split(',').ToList();

            List<string> filter = FormatSecondSeparation(secondInput);

            Dictionary<string, HashSet<string>> copyOfDict = new Dictionary<string, HashSet<string>>();

            copyOfDict = CopyDictionary(dictTopicsAndTags, copyOfDict);

            foreach (var kvp in dictTopicsAndTags)
            {
                string currentTopic = kvp.Key;
                HashSet<string> tagsInCurrentTopic = kvp.Value;
                
                if (!ListContainsAllFilterTags(filter, tagsInCurrentTopic))
                {
                    copyOfDict.Remove(currentTopic);
                }
            }

            foreach (var kvp in copyOfDict)
            {
                List<string> tags = kvp.Value.ToList();
                tags = AddHashtagToTags(tags);
            }

            foreach (var kvp in copyOfDict)
            {
                string topic = kvp.Key;
                HashSet<string> tags = kvp.Value;

                Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
            }
        }
        static List<string> FormatSeparation(List<string> topics)
        {
            string tagsStr = string.Empty;

            for (int i = 2; i < topics.Count; i++)
            {
                tagsStr += topics[i];
            }

            List<string> tags = tagsStr.Split(',').ToList();

            return tags;
        }
        static Dictionary<string, HashSet<string>> AddTagsToCurrentTopic(Dictionary<string, HashSet<string>> dictTopicsAndTags, string topic, List<string> tags)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                dictTopicsAndTags[topic].Add(tags[i]);
            }

            return dictTopicsAndTags;
        }
        static List<string> FormatSecondSeparation(List<string> tagsToFilter)
        {
            string tagsToFilterStr = string.Empty;

            for (int i = 0; i < tagsToFilter.Count; i++)
            {
                tagsToFilterStr += tagsToFilter[i];
            }

            List<string> filter = tagsToFilterStr.Split(' ').ToList();

            return filter;
        }
        static bool ListContainsAllFilterTags(List<string> filter, HashSet<string> tagsInCurrentTopic)
        {
            int counter = 0;

            for (int i = 0; i < filter.Count; i++)
            {
                if (tagsInCurrentTopic.Contains(filter[i]))
                {
                    counter++;
                }
            }
             
            if (counter == filter.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static List<string> AddHashtagToTags(List<string> tagsInCurrentTopic)
        {
            for (int i = 0; i < tagsInCurrentTopic.Count; i++)
            {
                tagsInCurrentTopic[i] = "#" + tagsInCurrentTopic[i];
            }

            return tagsInCurrentTopic;
        }
        static Dictionary<string, HashSet<string>> CopyDictionary(Dictionary<string, HashSet<string>> dictTopicsAndTags, Dictionary<string, HashSet<string>> copyOfDict)
        {
            foreach (var kvp in dictTopicsAndTags)
            {
                copyOfDict.Add(kvp.Key, kvp.Value);
            }

            return copyOfDict;
        }
    }
}
