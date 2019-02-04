using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // sozdaem class pod nazvaniem Student
    {
        public string name = "Adilbek"; // public stroku sozdaem pod nazvaniem name i prisvaivaem imya
        public string id = "18BD110315";//public stroku sozdaem pod nazvaniem id i prisvaivaem id
        public int year = 2019; // public integer sozdaem pod nazvaniem year i prisvaivaem year of study

        public void Print () // sozdaem method print kotoraya budet vyvodit' na ekran
        {
            Console.WriteLine("Name:" + name); 
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Year of study:" + year);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Adilbek = new Student(); // sozdaem studenta
            Adilbek.Print(); // peredaem v method Print
            Console.ReadKey();
        }
    }
}
