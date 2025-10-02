using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KruchininEP.Sprint1.Task6.V4.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Кручинин Е. П. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Кручинин Евгений Павлович. | РППб25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,    *");
            Console.WriteLine("* содержащие удвоенное н.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите сроку: ");
            string str = Console.ReadLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDoubleN(str));

            Console.ReadKey();
        }
    }
}