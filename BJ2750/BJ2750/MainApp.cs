using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2750
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int number;

            number = int.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Sort();
            foreach(int output in list)
            {
                Console.WriteLine(output);
            }
        }
    }
}
