using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KhvorykhVA.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");


            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int z = 2 * (x * x * x) + (x * x / 2) - (7 * x / 2) + 2;

            File.WriteAllText(path, z.ToString());
            return path;
        }
    }
}
