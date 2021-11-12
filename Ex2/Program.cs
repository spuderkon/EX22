using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу вывода на экран количества сотрудников, чей возраст кратен 3. Тип данных – коллекция.
            В текстовом файле записана информация о людях (фамилия, имя, отчество, возраст, вес через пробел). 
            Иванов Сергей Николаевич 21 64
            Петров Игорь Юрьевич 45 88
            Семёнов Михаил Алексеевич 20 70
            Пиманов Александр Дмитриевич 53 101
            Предусмотреть тестовые ситуации, проект выгрузить в репрозиторий*/

            /*
             *
             */

            List<string[]> listarr = new List<string[]>();
            StreamReader sr = new StreamReader("tx.txt");
            string[] arr = File.ReadAllLines("tx.txt");

            for (int i = 0; i < 4; i++)
            {
                listarr.Add(arr[i].Split(' '));
            }

            sr.Close();

            try
            {
                var cond = listarr.Where(x => int.Parse(x[3]) % 3 == 0);
                foreach (string[] x in cond)
                {
                    Console.WriteLine(string.Join(" ", x));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
