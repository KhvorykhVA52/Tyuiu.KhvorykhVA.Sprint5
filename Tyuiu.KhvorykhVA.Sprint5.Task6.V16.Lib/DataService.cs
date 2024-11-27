using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KhvorykhVA.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            int countEngWord = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                    {
                        char c = words[i][0];
                        if (char.IsBetween(c, 'A', 'Z') || char.IsBetween(c, 'a', 'z'))
                            countEngWord++;
                    }
                }
            }

            return countEngWord;
        }
    }
}
