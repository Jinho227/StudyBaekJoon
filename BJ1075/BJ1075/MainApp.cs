using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1075
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int N, F;
            N = int.Parse(Console.ReadLine());
            F = int.Parse(Console.ReadLine());

            for(int i = 0; i < 100; i++)
            {
                if ((N - (N % 100) + i) % F == 0)
                {
                    Console.WriteLine("{0:00}", i);
                    break;
                }
            }
            return;
        }
    }
}
