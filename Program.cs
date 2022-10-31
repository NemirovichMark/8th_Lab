using System;
using System.Text.RegularExpressions;
namespace _8th_Lab


{

    class Program
    {
        static bool is_in_arr(char[] arr, char x)
        {

            foreach (char xx in arr)
            {
                if (x == xx)
                {
                    return true;
                }
            }
            return false;
        }

        static string encode_message(string message)
        {
            string res = "";
            string s = ",.?!";
            char[] symbols = s.ToCharArray();

            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetter(message[i]))
                {
                    res += message[i];
                }
            }

            if (is_in_arr(symbols, message[message.Length - 1]))
            {
                res += message[message.Length - 1];
            }

            return res;
        }

        static string decode_message(string message)
        {
            return encode_message(message);
        }

        static void Main(string[] args)
        {
            #region task 1
            Console.WriteLine("task 1");
            {
                Console.WriteLine("enter the text in which you want to calculate the statistics");

                string? corpora = Console.ReadLine().ToLower();
                int char_counter = 0;
                Dictionary<char, double> cache = new Dictionary<char, double>();

                if (corpora == null)
                {
                    Console.WriteLine("gotcha - incorrect format!!!");
                    return;
                }

                for (int i = 0; i < corpora.Length; i++)
                {
                    char chr = corpora[i];

                    if (Char.IsLetter(chr))
                    {
                        char_counter++;
                        if (!cache.ContainsKey(chr))
                        {
                            cache[chr] = 1;
                        }
                        else
                        {
                            cache[chr] += 1;
                        }
                    }
                }


                foreach (char chr in cache.Keys)
                {
                    double c = cache[chr] / char_counter;
                    Console.WriteLine($"{chr} - {c}");
                }
            }
            #endregion

            #region task 2
            Console.WriteLine("task 2");
            {
                List<string> output_ = new List<string>();

                Console.WriteLine("write -1 as a stop sign");
                Console.WriteLine("please enter only letters or symbols which is an alphabet");
                Console.WriteLine("of the codebook, otherwise the info would be lost");

                while (true)
                {
                    string inp = Console.ReadLine();
                    if (inp == "-1")
                    {
                        break;
                    }

                    string[] line = inp.Split(" ");
                    string tmp = "";

                    foreach (string word in line)
                    {
                        tmp += decode_message(word);
                        tmp += " ";
                    }
                    output_.Add(tmp);
                }

                Console.WriteLine();
                foreach (string s in output_)
                {
                    Console.WriteLine(s);
                }
            }
            #endregion
        }
    }
}