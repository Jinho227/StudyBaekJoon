using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ25501
{
    class MainApp
    {
        static int count = 0;
        static int recursion(char[] s, int l, int r)
        {
            count++;
            if (l >= r) return 1;
            else if (s[l] != s[r]) return 0;
            else return recursion(s, l + 1, r - 1);
        }

        static int isPalindrome(char[] s)
        {
            return recursion(s, 0, s.Length - 1);
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            char[][] s = new char[number][];
            for(int i = 0; i< number; i++)
            {
                string input = Console.ReadLine();
                
                s[i] = new char[input.Length];
                int j = 0;
                foreach (char a in input)
                {
                    s[i][j++] = a;
                }
            }
            for(int i = 0; i < number; i++)
            {
                char[] output = new char[s[i].GetLength(0)];
                for (int j = 0; j < s[i].GetLength(0); j++)
                {
                    output[j] = s[i][j];
                }

                Console.WriteLine(isPalindrome(output) + " " + count);
                count = 0;
            }
            

        }
    }
}
