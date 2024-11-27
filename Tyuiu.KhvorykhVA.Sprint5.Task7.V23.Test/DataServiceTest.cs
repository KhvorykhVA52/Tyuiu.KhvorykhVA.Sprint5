using Tyuiu.KhvorykhVA.Sprint5.Task7.V23.Lib;
namespace Tyuiu.KhvorykhVA.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave()
        {
            string path =  @"C:\DataSprint5\OutPutDataFileTask7V23.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}