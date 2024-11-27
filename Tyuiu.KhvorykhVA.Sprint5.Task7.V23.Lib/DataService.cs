using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;
namespace Tyuiu.KhvorykhVA.Sprint5.Task7.V23.Lib
{
    
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return "Файл не найден.";
                }

                string data = File.ReadAllText(path);

                string pattern = @"\b[а-яА-ЯёЁ]+\b";

                string result = Regex.Replace(data, pattern, string.Empty);

                result = Regex.Replace(result, @"\s+", " ").Trim();


                string outputPath = Path.Combine(Path.GetDirectoryName(path), "OutPutDataFileTask7V23.txt");

                File.WriteAllText(outputPath, result);

                return $"Данные успешно обработаны. Результат сохранен в {outputPath}.";
            }
            catch (Exception ex)
            {
                return $"Произошла ошибка: {ex.Message}";
            }
        }
    }
}




    
