using Tyuiu.KhvorykhVA.Sprint5.Task6.V16.Lib;
namespace Tyuiu.KhvorykhVA.Sprint5.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | ВыполниЛ Хворых В. А. | АСОиУБ-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                              *");
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #16                                                                 *");
            Console.WriteLine("* Выполнил Хворых Виктор Александрович | АСОиУБ-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Взять файл в котором есть набор символьных данных.                          *");
            Console.WriteLine("* Найти количество английских слов в заданной строке.                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(@"Файл: C:\DataSprint5\InPutDataFileTask6V16.txt" + "\n");
            Console.WriteLine("Содeржимое файла: ");
            using (StreamReader rs = new StreamReader(@"C:\DataSprint5\InPutDataFileTask6V16.txt"))
            {
                Console.WriteLine(rs.ReadLine() + "\n");
            }
            int res = ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask6V16.txt");
            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}