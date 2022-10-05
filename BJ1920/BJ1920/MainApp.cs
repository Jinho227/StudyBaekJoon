using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1920
{
    class MainApp
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            int Nnumber = int.Parse(Console.ReadLine());
            int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int Mnumber = int.Parse(Console.ReadLine());
            int[] Mtemp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < Mtemp.Length; i++)
            {
                if(temp.Contains(Mtemp[i]))
                    s.AppendLine("1"); // wirteline은 속도가 느리다.
                else
                    s.AppendLine("0");
            }
            Console.WriteLine(s);
        }
    }
}
