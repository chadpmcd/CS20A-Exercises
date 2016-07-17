using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            int divisor = 7;
            Console.Write("Enter first integer: ");
            string strinteger1 = Console.ReadLine();

            Console.Write("Enter second integer: ");
            string strinteger2 = Console.ReadLine();
            int integer1;
            int integer2;
            int.TryParse(strinteger1, out integer1);
            int.TryParse(strinteger2, out integer2);

            int counter = 0;

            //switch the numbers if integer 1 is bigger than integer2
            if (integer1 > integer2)
            {
                int tmp = integer1;
                integer1 = integer2;
                integer2 = tmp;
            }

            //Go through and get modulus on all and count the number divisible by divisor
            for (int i = integer1; i <= integer2; i++)
            {
                int mod = i % divisor;

                if (mod == 0)
                {
                    counter++;
                }


            }

            Console.WriteLine("There are {0} numbers divisible by {1} between {2} and {3}", counter, divisor, integer1, integer2);

            Console.ReadLine();

        }
    }
}
