using System.Security.Cryptography;
using Tyuiu.KruchininEP.Sprint1.Task7.V28.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Кручинин Е. П. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Кручинин Евгений Павлович    | РППб25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным данным, вводимых пользователем                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" z = cos^2*(sin 1/x)+y^x                                                   ");
            double x, y;
            Console.WriteLine("Введите значение х:                                                        ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:                                                        ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = Convert.ToDouble(ds.Calculate(x, y));
            Console.WriteLine($"z={res}");
            Console.ReadKey();



        }
    }
}