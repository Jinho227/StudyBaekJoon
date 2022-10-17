using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ14425
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] s = Console.ReadLine().Split();
            int N = Convert.ToInt32(s[0]);
            int M = Convert.ToInt32(s[1]);
            string[] NString = new string[N];
            string[] MString = new string[M];

            for (int i = 0; i < N; i++)
            {
                NString[i] = Console.ReadLine();
            }
            Array.Sort(NString);
            for (int i = 0; i < M; i++)
            {
                MString[i] = Console.ReadLine();
                string temp = MString[i];
                if (Array.BinarySearch(NString, temp) >= 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
