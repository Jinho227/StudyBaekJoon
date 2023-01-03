using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ3036
{
    class Fraction
    {
        public int numerator;
        public int denominator;
        public void fraction(int a, int b)
        {
            int[] primenumber = new int[b];
            int j = 0;
            numerator = b;
            denominator = a;
            for (int i = 2; i <= b; i++)
            {
                if (b % i == 0)
                {
                    primenumber[j] = i;
                    j++;
                }
            }
            for (int i = j - 1; i >= 0; i--)
            {
                if (denominator % primenumber[i] == 0 & numerator >= primenumber[i])
                {
                    denominator = denominator / primenumber[i];
                    numerator = numerator / primenumber[i];
                }
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();
            int n = int.Parse(Console.ReadLine());

            string[] temp = Console.ReadLine().Split();
            //int[] s = new int[n];

            for(int i = 1; i < n; i++)
            {
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[i]);

                if(a > b)
                {
                    f.fraction(a, b);
                    Console.WriteLine(f.denominator + "/" + f.numerator);
                }
                else if(a < b)
                {
                    f.fraction(b, a);
                    Console.WriteLine(f.numerator + "/" + f.denominator);
                }
                else
                {
                    Console.WriteLine("1/1");
                }
            }
        }
    }
}

// gcd에 대한 내용 숙지 문제 풀이 실패

