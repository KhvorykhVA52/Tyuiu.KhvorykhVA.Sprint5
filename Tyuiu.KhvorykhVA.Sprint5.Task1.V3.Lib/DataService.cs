using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KhvorykhVA.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (2.5 + i != 0)
                {
                    y = Math.Round(Math.Cos(2 * i) + Math.Sin(i) / (i + 2.5) + 2 * i, 2);
                }
                else
                {
                    y = 0;
                }
                strY = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
