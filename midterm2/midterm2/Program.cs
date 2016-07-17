using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] testarray = { 1, 2, 4, 18, 50, 120, 500 };
            if(CheckSuperIncreasing(testarray))
            {
                Console.WriteLine("The array is super-increasing");
            } else
            {
                Console.WriteLine("The array is not super-increasing");
            }

            Console.ReadLine();
        }

        public static bool CheckSuperIncreasing(int[] A)
        {
            bool check;
            check = true;
            for (int i = 0; i < A.Length;i++)
            {
                if(i == 0 || i == 1 )
                {
                    continue;
                }
                int sum = A[i - 2] + A[i - 1];
                if (A[i] <= sum)
                {
                    check = false;
                }
            }

            return check;
        }
    }
}
