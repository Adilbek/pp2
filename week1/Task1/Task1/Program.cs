using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            List<int> l = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            string[] s = Console.ReadLine().Split();
            for(int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(s[i]);
            }
            for(int i = 2; (i*i) <= n; i++)
            {
                if(ar[i] % i != 0)
                {
                    l.Add(ar[i]);
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
            foreach (int s1 in l)
            {
                Console.Write(s1 + " ");
            }
            Console.ReadKey();
        }
    }
}
