using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Tyuiu.KruchininEP.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 1 | Выполнил: Кручинин Е. П. | РППб-25-1";
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                          *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                *");
            Console.WriteLine("* Задание #2                                                                         *");
            Console.WriteLine("* Вариант #19                                                                        *");
            Console.WriteLine("* Выполнил: Кручинин Евгений Павлович | РППб-25-1                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,            *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                        *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("* Известно расстояние в дюймах. Вычислить расстояние в метрах.                       *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                         *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            Console.Write("Введите расстояние в дюймах: ");
            int inches = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            double A = ds.ConvertInchToKm(inches);
            Console.WriteLine($"Расстояние в метрах: {A:F3}");

            Console.ReadLine();
        }
    }
}