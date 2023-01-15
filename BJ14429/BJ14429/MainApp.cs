using System;

namespace BJ14429
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[,] temp = new int[n, 2];
            int[] a = new int[2];
            int x = 0;
            int k = 0;
            for(int i = 0; i< n; i++)
            {
                string[] s = Console.ReadLine().Split();
                temp[i, 0] = Convert.ToInt32(s[0]);
                temp[i, 1] = Convert.ToInt32(s[1]);
            }
            int j = 0;
            while (j < n) 
            {
                k = 0;
                x = 0;
                int y = (temp[j, 0] - 1) % (temp[j, 1] + 1);
                x += y;
                while (x < temp[j, 0])
                {
                    x += temp[j, 1] + 1;
                    k++;
                }  
                if(j == 0)
                {
                    a[0] = j + 1;
                    a[1] = k * 2;
                }
                else
                {
                    if(a[1] > k * 2)
                    {
                        a[0] = j + 1;
                        a[1] = k * 2;
                    }
                }
                j++;
            }
            Console.WriteLine(a[0] + " " + a[1]);
        }
    }
}
