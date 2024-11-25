using Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Lib;
namespace Tyuiu.KhvorykhVA.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}