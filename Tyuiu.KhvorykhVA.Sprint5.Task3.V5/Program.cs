using System;
using Tyuiu.KhvorykhVA.Sprint5.Task3.V5.Lib;

namespace Tyuiu.KhvorykhVA.Sprint5.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Хворых В.А  | АСОиУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в бинарный файл       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Хворых Виктор Александрович | АСОиУБ-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 2, результат сохранить    *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.               *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int x = 2; 
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            string filePath = dataService.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Результат успешно сохранён!");
            Console.ReadKey();
        }
    }
}
