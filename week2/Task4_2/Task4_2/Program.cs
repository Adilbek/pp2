
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {

        public static void Start()
        {
            string origin = @"C:\lecture\pp2\week2\Task4_2\Task4_2\path";  // основная папка 
            string fileName = Console.ReadLine();          // имя папки через консоль

            origin = Path.Combine(origin, fileName);   // создал файл в основной папке    

            File.WriteAllText(origin, "comment");    //  комментируем

            string copy = @"C:\lecture\pp2\week2\Task4_2\Task4_2\path1";     // папка куда будем скопировать 
            string copyfile = Path.Combine(copy, fileName);  //создаем файл на ложной папке

            File.Copy(origin, copyfile, true);     //скопируем файл с основного на ложный

            Delete(origin);        // вызываю метод чтобы удалить основной файл
        }

        public static void Delete(string path)
        {
            if (File.Exists(path))
            {     // если папка существует, удаляю
                File.Delete(path);
            }
        }

        public static void Main(string[] args)
        {
            Start();       //вызываю метод



        }
    }
}