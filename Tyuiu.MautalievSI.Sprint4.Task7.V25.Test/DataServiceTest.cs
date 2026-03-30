using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint4.Task7.V25.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "348561792486";

            int res = ds.Calculate(n, m, value);

            Assert.AreEqual(38, res);
        }
    }
}