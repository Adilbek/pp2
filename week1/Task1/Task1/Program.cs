using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(); // 1 2 3 4 5
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            f1(arr, n);

        }

        public static void f1(int[] a, int m)
        {
            List<int> l = new List<int>(2 * m);
            for (int i = 0; i < m; i++)
            {
                l.Add(a[i]);
                l.Add(a[i]);
            }

            foreach (int s3 in l)
            {
                Console.Write(s3 + " ");

            }
            Console.ReadKey();
        }
    }
}
