using System;


namespace BJ1010
{
    class MainApp
    {
        static ulong Bridge(int n, int m)
        {
            ulong np = 1;
            ulong mp = 1;
            if (m / 2 < n) n = m - n;
            for (int i = 1; i <= n; i++)
            {
                np = np * (ulong)i;
            }
            for (int i = (m - n) + 1; i <= m; i++)
            {
                mp *= (ulong)i;
            }

            return (mp / np);
        }

        static void Main(string[] args)
        {
            int number;
            int[,] s;
            number = int.Parse(Console.ReadLine());
            s = new int[number, 2];
            int n, m;

            for(int i = 0; i < number; i++)
            {
                string[] temp = Console.ReadLine().Split();
                s[i, 0] = int.Parse(temp[0]);
                s[i, 1] = int.Parse(temp[1]);
            }

            for(int i = 0; i< number; i++)
            {
                n = s[i, 0];
                m = s[i, 1];

                Console.WriteLine(Bridge(n, m));
            }
            return;
        }
    }
}
