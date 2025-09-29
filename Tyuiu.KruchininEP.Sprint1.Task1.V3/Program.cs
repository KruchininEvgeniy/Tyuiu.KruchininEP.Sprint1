using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Tyuiu.KruchininEP.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 1 | Выполнил: Кручинин Е. П. | РППб-25-1";
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                          *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                           *");
            Console.WriteLine("* Задание #1                                                                         *");
            Console.WriteLine("* Вариант #3                                                                         *");
            Console.WriteLine("* Выполнил: Кручинин Евгений Павлович | РППб-25-1                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет  *");
            Console.WriteLine("* результат по формуле (x-y)/(x+3)+3 и печатает его на экране.                       *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("************************************************************************************ *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("************************************************************************************ *");

            double x, y;


            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите значеине Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("************************************************************************************ *");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("************************************************************************************ *");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();

        }
    }
}