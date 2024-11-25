using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
using System.IO;

namespace Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double result = 0; 
            var numbers = new System.Collections.Generic.List<int>(); 

            try
            {

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var part in parts)
                        {
                            if (int.TryParse(part, out int number) && number >= -9 && number <= 9)
                            {
                                numbers.Add(number); 
                            }
                        }
                    }
                }

                if (numbers.Count > 0)
                {
                    int max = numbers.Max(); 
                    int min = numbers.Min(); 

                    Console.WriteLine($"Максимум: {max}, Минимум: {min}");

                    result = max - min; 
                    result = Math.Round(result, 3); 
                }
                else
                {
                    Console.WriteLine("В файле нет однозначных целых чисел.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            return result;
        }
    }
}
