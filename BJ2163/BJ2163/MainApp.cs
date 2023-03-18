using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2163
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            int n = Int32.Parse(s[0]);
            int m = Int32.Parse(s[1]);

            Console.WriteLine(m * n - 1);
        }
    }
}
