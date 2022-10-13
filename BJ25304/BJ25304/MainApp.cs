using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ25304
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int cost = Convert.ToInt32(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());
            int[,] bill = new int[number, 2];
            string[] s;
            int sum = 0;
            for(int i = 0; i < number; i++)
            {
                s = Console.ReadLine().Split();
                bill[i, 0] = Convert.ToInt32(s[0]);
                bill[i, 1] = Convert.ToInt32(s[1]);
                sum += bill[i, 0] * bill[i, 1];
            }
            if (sum == cost)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
