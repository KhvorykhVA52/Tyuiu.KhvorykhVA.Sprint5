using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            var culture = CultureInfo.InvariantCulture; 

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, NumberStyles.Float, culture, out double number))
                    {
                        res += number;
                    }
                    else
                    {
                        Console.WriteLine($"Некорректная строка: {line}");
                    }
                }
            }
            return res;
        }
    }
}
