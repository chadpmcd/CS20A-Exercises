using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter text:");
            string txt = Console.ReadLine();

            char[] charlist = txt.ToCharArray();

            var distchars = charlist.Distinct();

            foreach (char distchar in distchars)
            {
                Console.Write(distchar);
            }


            // This is added to prevent the window from closing automatically
            // Serves no other purpose
            Console.ReadKey();
        }
    }
}
