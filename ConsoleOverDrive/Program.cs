using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOverDrive
{
    class Program
    {
        static void Main(string[] args)
        {

          string ReadString = Console.ReadLine();
            List<string> wordArry = ReadString.Split(' ').ToList<string>();
            foreach (string word in wordArry)
            {
                int NumberOfVowels = VowelsCount(word);

                Console.WriteLine(word + " " + NumberOfVowels.ToString()+"");
            }

             Console.ReadLine();
        }

        private static int VowelsCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i].ToString().ToLower())
                {
                    case "a":
                        count = count + 1;
                        break;
                    case "e":
                        count = count + 1;
                        break;

                    case "i":
                        count = count + 1;
                        break;
                    case "o":
                        count = count + 1;
                        break;
                    case "u":
                        count = count + 1;
                        break;
                    case "Y":
                        count = count + 1;
                        break;

                }
            }

            return count;

        }
    }
}
