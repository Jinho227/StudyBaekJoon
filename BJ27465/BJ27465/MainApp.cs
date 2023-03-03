using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ27465
{
    class MainApp
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            if (N <= 3)
                Console.WriteLine(4);
            else
            {
                if (N % 2 == 0)
                    Console.WriteLine(N);
                else if (N == 1000000000)
                    Console.WriteLine(N);
                else
                    Console.WriteLine(N + 1);
            }
            

        }
    }
}
