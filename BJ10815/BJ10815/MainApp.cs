using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ10815
{
    class MainApp
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int[] firstCard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(firstCard);
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int[] secondCard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for(int i = 0; i < secondNumber; i++)
            {
                if (Array.BinarySearch(firstCard, secondCard[i]) >= 0)
                    s.Append("1");
                else
                    s.Append("0");
                s.Append(" ");
            }
            Console.WriteLine(s);
        }
    }
}
