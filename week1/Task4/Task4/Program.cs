using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int razmer = int.Parse(Console.ReadLine()); // sozdaem peremennuyu dlya razmera
            for (int i = 1; i <= razmer; i++)// column nachinaetsya s edinichki do razmera
            {
                for (int j = 1; j <= i; j++)// row budet uvelichivat'sya s edinicki do column
                    Console.Write("[*]"); // pomechaem [*]
                Console.WriteLine(" ");// piwem kazhdyi sludyuwiy cikl v druguyu liniyu
                    
                    
            }
           Console.ReadKey();
        }
    }
}
