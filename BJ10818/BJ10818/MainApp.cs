using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ10818
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split();
            int min = 1000000;
            int max = -1000000;
            foreach(string s in a)
            {
                if (min > int.Parse(s))
                    min = int.Parse(s);
                if (max < int.Parse(s))
                    max = int.Parse(s);
            }
            Console.WriteLine(min + " " + max);
        }
    }
}
