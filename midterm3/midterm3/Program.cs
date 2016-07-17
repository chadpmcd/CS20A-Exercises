using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int start = 1;
            int end = 100000;

            //Run through the full list and test
            for (int i = start; i <=end;i++)
            {
                bool check = TestFor3or5(i);
                if (check)
                {
                    Console.Write("This number has either 3s or 5s in it but not both: ");
                    Console.WriteLine(i);
                }
            }

            //This just keeps the console from closing
            Console.ReadLine();
        }

        private static bool TestFor3or5(int i)
        {
            //Initialize the checks
            bool check = false;
            bool check3 = false;
            bool check5 = false;

            //Convert the int to a string
            string stringi = i.ToString();

            //Go through each digit in the number
            for (int j = 0; j < stringi.Length; j++)
            {

                //Test for 3
                if (stringi[j] == '3')
                {
                    check3 = true;
                }
                //Test for 5
                if (stringi[j] == '5')
                {
                    check5 = true;
                }
                
            }

            //Check for either 3 or 5 and set to true
            if (check3 || check5)
            {
                check = true;
            }

            //Check for both 3 and 5 which is not allowed so set to false
            if (check3 && check5)
            {
                check = false;
            }

            return (check);
           
        }
    }
}
