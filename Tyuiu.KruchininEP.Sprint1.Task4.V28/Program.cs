using Tyuiu.KruchininEP.Sprint1.Task4.V28.Lib;
namespace Tyuiu.KruchininEP.Sprint1.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Кручинин Е. П. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил:  Кручинин Евгений Павлович | РППб25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("cos(60*pi / 2) / Exp(2 * x + y)= " + ds.Calculate(x, y));

            Console.ReadKey();

        }
    }
}