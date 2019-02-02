using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n]; // sozdaem massiv
            string[] s = Console.ReadLine().Split(); 
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            f1(arr, n); // vyzyvaem methode pod nazvaniem f1

        }

        public static void f1(int[] a, int m) // peredaem massiv i peremennuyu m (razmernost')
        {
            List<int> l = new List<int>(2 * m); // sozdaem list razmerom 2*array
            for (int i = 0; i < m; i++)
            {
                l.Add(a[i]);// dva raza dobavlyayu v list
                l.Add(a[i]);
            }

            foreach (int s3 in l)
            {
                Console.Write(s3 + " ");// vyvod s probelom s odnu stroku

            }
            Console.ReadKey();
        }
    }
}
