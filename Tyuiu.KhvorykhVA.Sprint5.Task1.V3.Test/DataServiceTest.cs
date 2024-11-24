using Tyuiu.KhvorykhVA.Sprint5.Task1.V3.Lib;
using System.IO;
using System.Reflection;
namespace Tyuiu.KhvorykhVA.Sprint5.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}