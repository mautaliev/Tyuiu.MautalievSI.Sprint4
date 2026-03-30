using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint4.Task2.V19.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9, 4, 5 };

            int res = ds.Calculate(array);

            Assert.AreEqual(52, res);
        }
    }
}