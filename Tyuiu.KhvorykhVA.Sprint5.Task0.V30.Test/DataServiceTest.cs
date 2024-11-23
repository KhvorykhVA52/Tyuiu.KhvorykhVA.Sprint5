using System.IO;
using Tyuiu.KhvorykhVA.Sprint5.Task0.V30.Lib;
namespace Tyuiu.KhvorykhVA.Sprint5.Task0.V30
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }




    }
}