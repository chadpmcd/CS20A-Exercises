using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Excercises
{
    class Program
    {
        static void Main(string[] args)
        {

                        //Reverse program start
            Console.WriteLine("Enter a string and I will reverse it.");
            string word = Console.ReadLine();
            Console.WriteLine("Here's the word: " + reverseWord(word));
            Console.Read();
            //Reverse program end







        }

        static string reverseWord(string word)
        {
            StringBuilder reversed = new StringBuilder();

            for(int i= word.Length - 1; i >= 0 ; i--)
            {
                reversed.Append(word[i]);
            }
            return reversed.ToString();
        }
    }
}
