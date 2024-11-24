using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KhvorykhVA.Sprint5.Task0.V30.Lib

{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double z = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}