using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            var culture = CultureInfo.InvariantCulture;

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine(); 
                if (line != null)
                {
                    string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (double.TryParse(parts[0], NumberStyles.Float, culture, out double firstNumber) &&
                        double.TryParse(parts[1], NumberStyles.Float, culture, out double secondNumber))
                    {
                        return firstNumber + secondNumber;
                    }
                }
            }
            return 0;
        }
    }
}
