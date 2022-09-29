using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bj3052
{
    class mainApp
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            string temp;
            int count = 1;
            bool isExisted = false;

            for(int i = 0; i < 10; i++)
            {
                temp = Console.ReadLine();
                number[i] = int.Parse(temp) % 42;
            }

            for (int i = 9; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == i)
                        continue;
                    if (number[i] == number[j])
                        isExisted = true;
                }
                if (isExisted == false)
                    count++;
                else
                    isExisted = false;
            }

            Console.WriteLine(count);
        }
    }
}
