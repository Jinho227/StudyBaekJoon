using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2798
{
    class MainApp
    {
        static int BlackJack(int[] card, int M)
        {
            int sum = 0;
            for(int i = 0; i < card.Length; i++)
            {
                for (int j = i + 1; j < card.Length; j++)
                {

                    for (int k = j + 1; k < card.Length; k++)
                    {
                        int temp = card[i] + card[j] + card[k];
                        if (temp <= M)
                            if (temp > sum)
                                sum = temp;
                    }
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int N = Convert.ToInt32(s[0]);
            int M = Convert.ToInt32(s[1]);
            int[] card = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(BlackJack(card, M));

        }
    }
}
