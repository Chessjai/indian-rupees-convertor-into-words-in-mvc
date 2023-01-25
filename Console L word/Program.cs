using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console_L_word
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter String");
            string input = Console.ReadLine();

            IDictionary<string, int> WordsArray = new Dictionary<string, int>();
            string TempWord = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    if (!string.IsNullOrEmpty(TempWord))
                    {

                        WordsArray.Add(TempWord, TempWord.Length);
                    }

                    TempWord = string.Empty;
                    TempWord += input[i];
                }
                else
                { TempWord += input[i]; }


            }
            if (!string.IsNullOrEmpty(TempWord))
            {
                WordsArray.Add(TempWord, TempWord.Length);

            }
            var maxValueKey = WordsArray.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            //string output = new string(input.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
            string value3 = RemoveDigits(maxValueKey);
            Console.WriteLine($"The maximum length word is : {value3}");
            Console.ReadKey();
        }
        public static string RemoveDigits(string key)
        {

            return Regex.Replace(key, @"\d", "");
        }

    }
}