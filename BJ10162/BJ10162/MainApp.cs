using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ10162
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            int[] timer = new int[3];

            if(T % 10 != 0)
            {
                Console.WriteLine(-1);
            }
            else // 속도 개선 방안 : 나눗셈으로 구현
            {
                while(T != 0)
                {
                    if(T - 300 >= 0)
                    {
                        T = T - 300;
                        timer[0] += 1;
                    }
                    else if(T - 60 >= 0)
                    {
                        T = T - 60;
                        timer[1] += 1;
                    }
                    else
                    {
                        T = T - 10;
                        timer[2] += 1;
                    }
                }

                Console.WriteLine(timer[0] + " " + timer[1] + " " + timer[2]);
            }
        }
    }
}
