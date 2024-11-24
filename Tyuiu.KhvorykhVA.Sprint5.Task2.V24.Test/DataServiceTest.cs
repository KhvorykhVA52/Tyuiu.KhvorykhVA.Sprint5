using Tyuiu.KhvorykhVA.Sprint5.Task2.V24.Lib;
using System.IO;
namespace Tyuiu.KhvorykhVA.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask2.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}