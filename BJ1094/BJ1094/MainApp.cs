using System;

namespace BJ1094
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int x = 64;
            int i = 0;
            int sum = 0;
            if (N == 64)
            {
                i++;
            }
            else
            {
                while (true)
                {
                    if (N < sum)
                        sum -= x;
                    else if (N > sum)
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                    x /= 2;
                    sum += x;
                }
            }
            Console.WriteLine(i);
        }
    }
}
