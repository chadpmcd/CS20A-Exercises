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

            /*
                        //Reverse program start
            Console.WriteLine("Enter a string and I will reverse it.");
            string word = Console.ReadLine();
            Console.WriteLine("Here's the word: " + reverseWord(word));
            Console.Read();
            //Reverse program end
            */


            //Parens in Math equations
            Console.WriteLine("Enter a math equation and I will check that the parens are nested incorrectly.");
            string equation = Console.ReadLine();
            checkParen(equation);

            //rule 1 - No starting with a close paren
            //rule 2 - make sure that there are enough parens 1 close for each open







            //At the end of all the programs to keep the console from closing
            string word = Console.ReadLine();






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


        static void checkParen(string equation)
        {
            //Loop through the list of parens and check to see if the parens are in the correct order
            //Give each paren a value - left/open  parens = 1 and right/close parens = -1
            //You are never allowed to go below 0 as you go through the list.  

            int counter = 0;
            int location = 1;
            int errorcount = 0;
            for (int i = 0; i < equation.Length ; i++)
            {

                location = i + 1;
                if (equation[i].Equals('('))
                {
                    counter = counter + 1;
                } else if (equation[i].Equals(')'))
                {
                    counter = counter - 1;
                }

                //Console.Write("The current char: ");
                //Console.WriteLine(equation[i]);
                //Console.Write("The counter: ");
                //Console.WriteLine(counter);
                //Console.Write("The location: ");
                //Console.WriteLine(location);



                if (counter < 0)
                {
                    Console.WriteLine("You have a misplaced paren at character position {0} of your expression.", location);
                    counter = 0;
                    errorcount = errorcount + 1;
                }


                //Console.Write("The error count: ");
                //Console.WriteLine(errorcount);
                //Console.WriteLine();

            }
            if (counter > 0 )
            {
                Console.WriteLine("You haven't closed all your parens");
            } else if (counter == 0 & errorcount == 0)
            {
                Console.WriteLine("Looks good!");
            }

        }
    }
}
