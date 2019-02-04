using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // razmernost' massiva
            int[] arr = new int[n]; // massiv na n elementov
            List<int> l = new List<int>();  // list dlya hraneniya prostyh chisel

            string[] str = Console.ReadLine().Split(); // ne schital probely dlya zapiski v odnu stroku

            for (int i = 0; i < n; i++) // probezhayus' po vsemu massivu
            {
                arr[i] = int.Parse(str[i]);  // prochital massiv
            }
            for (int i = 0; i < n; i++)// probezhalsya po massivu
            {
                if (f1(arr[i]) == 1) // peredayu v method f1
                {
                    l.Add(arr[i]); // esli [i] raven 1 dobavlyaem v list
                }
            }

            Console.WriteLine(l.Count); // schitanie kolichestvo prostyh chisel

            for (int i = 0; i < l.Count; i++) // probezhalsya po vsemu listu
            {
                Console.Write(l[i] + " "); // vvozhu chisla v liste s probelom
            }
            Console.ReadLine();
        }

        public static int f1(int num) // sozdaem method f1( special int potomu chto ono dolzhno chto-to vozvrawat'
        {
            for (int i = 2; i <= num; i++) // probezhaemsya po vsem chislam ot 2
            {
                if ((i == num) || (i > Math.Sqrt(num))) // esli i ravno chislu kotoromu my peredali vozvrawaet 1
                {
                    return 1;                           // nam nado proverit' do kornya po Reweto Erastosphene
                }
                if (num % i == 0 && i != num || num == 1)  // delaem iskluchenie 1 i 0, esli ine ravno num, to est' delyatsya na chislo pod kornya
                                                           //vozvrawaet 0
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}