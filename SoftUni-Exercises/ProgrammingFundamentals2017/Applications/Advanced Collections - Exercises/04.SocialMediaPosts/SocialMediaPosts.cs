using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SocialMediaPosts
{
    class SocialMediaPosts
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            var data = new Dictionary<string, Dictionary<string, int>>();
            var commentsData = new Dictionary<string, List<string>>();

            while (input[0] != "drop")
            {
                string action = Correct(input); // Converting like => Likes and dislike => Dislikes for later in the code
                string currentPost = input[1];

                switch (input[0])
                {
                    case "post":
                        if (!data.ContainsKey(input[1]))
                        {
                            data[currentPost] = new Dictionary<string, int>();
                        }
                        break;
                    case "like":
                        if (data.ContainsKey(input[1]))
                        {
                            if (!data[currentPost].ContainsKey(action))
                            {
                                data[currentPost][action] = 0;
                            }
                            data[currentPost][action]++;
                        }
                        break;
                    case "dislike":
                        if (data.ContainsKey(currentPost))
                        {
                            if (!data[currentPost].ContainsKey(action))
                            {
                                data[currentPost][action] = 0;
                            }
                            data[currentPost][action]++;
                        }
                        break;
                }

                commentsData = AddPostsToCommentsDictionary(data, commentsData);

                if (input[0] == "comment")
                {
                    if (commentsData.ContainsKey(currentPost))
                    {
                        commentsData[currentPost].Add(AddCommentToCommentData(input));
                    }
                }

                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var kvp in data)
            {
                string post = kvp.Key;
                Dictionary<string, int> values = kvp.Value;

                Console.Write($"Post: {post} ");

                foreach (var kvp2 in values.OrderByDescending(x => x.Key))
                {
                    string action = kvp2.Key;

                    if (action == "Dislikes" && values.Count == 1)
                    {
                        Console.Write("| Likes: 0 ");
                    }
                    int value = kvp2.Value;

                    Console.Write($"| {action}: {value} ");

                    if (values.Count == 1 && action == "Likes")
                    {
                        Console.Write("| Dislikes: 0");
                    }

                }

                if (values.Count == 0)
                {
                    Console.Write("| Likes: 0 | Dislikes: 0");
                }

                Console.WriteLine();
                Console.WriteLine("Comments:");

                if (commentsData[post].Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comment in commentsData[post])
                    {
                        List<string> commentsToList = comment.Split(' ').ToList();
                        string commentator = commentsToList[0];
                        commentsToList.RemoveAt(0);

                        Console.WriteLine($"*  {commentator}: {string.Join(" ", commentsToList)}");
                    }
                }
            }
        }
        static string Correct(List<string> input)
        {
            string action = input[0];
            char c = char.Parse(action[0].ToString().ToUpper());
            action = action.Replace(action[0], c);
            action = action.Insert(action.Length, "s");

            return action;
        }
        static Dictionary<string, List<string>> AddPostsToCommentsDictionary(Dictionary<string, Dictionary<string, int>> data, Dictionary<string, List<string>> commentsData)
        {
            foreach (var key in data.Keys)
            {
                if (!commentsData.ContainsKey(key))
                {
                    commentsData[key] = new List<string>();
                }
            }

            return commentsData;
        }
        static string AddCommentToCommentData(List<string> input)
        {
            string comment = string.Empty;

            for (int i = 2; i < input.Count; i++)
            {
                comment += input[i] + " ";
            }

            comment.TrimEnd();

            return comment;
        }

    }
}
