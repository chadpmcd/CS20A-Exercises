using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "../../example.txt";
            string line;
            List<string> lines = new List<string>();

            // load data
             StreamReader reader = new StreamReader(file);
            using (reader)
            {
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                    lines.Add(i + " " + line);
                }
            }
            reader.Close();

            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (string l in lines)
                {
                    sw.WriteLine(l);
                }
                sw.Close();
            }



            // This is added to prevent the window from closing automatically
            // Serves no other purpose
            Console.ReadKey();
        }
    }
}
