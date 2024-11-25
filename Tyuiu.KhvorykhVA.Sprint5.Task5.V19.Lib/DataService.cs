using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
using System.IO;

namespace Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            var culture = new CultureInfo("ru-RU"); 

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 2)
                    {
                        if (double.TryParse(parts[0], NumberStyles.Float, culture, out double firstNumber) &&
                            double.TryParse(parts[1], NumberStyles.Float, culture, out double secondNumber))
                        {
                            res = firstNumber + secondNumber; 
                        }
                    }
                }
            }
            return res;
        }
    }
}
