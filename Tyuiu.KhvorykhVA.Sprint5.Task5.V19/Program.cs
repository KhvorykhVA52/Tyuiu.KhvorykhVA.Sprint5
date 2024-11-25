using Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Lib;
namespace Tyuiu.KhvorykhVA.Sprint5.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
            Console.Write("Данные находяться в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма элеметов файла = " + res);
            Console.ReadKey();


        }


    }





}