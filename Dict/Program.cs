using System;
using System.Collections.Generic;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(11, "Ahmet");
            students.Add(12, "Ayşe");
            students.Add(13, "Mehmet");
            students.Add(14, "Fatma");

            foreach (var all in students)
            {
                Console.WriteLine(all);
            }

            var mevcut = students.Count;
            {
                Console.WriteLine();
                Console.WriteLine("Toplam Öğrenci Sayısı: " + mevcut);
            }




            students.Remove(11);
            Console.WriteLine();
            foreach (var all in students)
            {
                Console.WriteLine(all);
            }
            Console.ReadLine();
        }
    }
}
