using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BJ1032
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string name = "";
            char Q = '?';
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 50)
                    return;
                for (int i = 0; i < number; i++)
                {
                    if(i == 0)
                        name = Console.ReadLine();
                    else
                    {
                        string temp = Console.ReadLine();
                        for(int j = 0; j < temp.Length; j++)
                        {
                            if (name[j] != temp[j])
                                name = name.Remove(j, 1).Insert(j, Q.ToString());
                        }
                    }
                }
                Console.WriteLine(name);
                return;
            }
            catch 
            {
                return;
            }

        }
    }
}
