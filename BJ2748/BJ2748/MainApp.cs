using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2748
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ulong f1 = 0;
            ulong f2 = 1;
            ulong f3;
            int n = Int32.Parse(Console.ReadLine());
            ulong a = 0;

            for(int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    a = 0;
                }
                else if(i == 1)
                {
                    a = 1;
                }
                else
                {
                    f3 = f1 + f2;
                    a = f3;
                    f1 = f2;
                    f2 = f3;
                }
            }
            Console.WriteLine(a);
        }


    }
}
