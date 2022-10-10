using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2525
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int h, m;
            h = int.Parse(a[0]);
            m = int.Parse(a[1]);

            int p = int.Parse(Console.ReadLine());

            if(m + p < 60)
            {
                Console.WriteLine(h + " " + (m+p));
            }
            else
            {
                if ((h + (p / 60) + ((m + (p % 60)) / 60)) >= 24)
                {
                    if(m+(p%60) >= 60)
                        Console.WriteLine((h + (p / 60) - 24 + ((m + (p % 60)) / 60)) + " " + ((m + (p % 60)) % 60));
                    else
                    {
                        Console.WriteLine((h + (p / 60) - 24) + " " + (m + (p % 60)));
                    }
                }
                   
                else
                {
                    if (m + (p % 60) >= 60)
                        Console.WriteLine((h + (p / 60) + ((m + (p % 60)) / 60)) + " " + ((m + (p % 60)) % 60));
                    else
                    {
                        Console.WriteLine((h + (p / 60)) + " " + (m + (p % 60)));
                    }
                }
            }
        }
    }
}
