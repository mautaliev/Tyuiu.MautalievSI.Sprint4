using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint4.Task4.V7.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,]
            {
                {4, 3, 6, 5, 5},
                {3, 4, 4, 6, 4},
                {6, 4, 6, 4, 5},
                {5, 4, 4, 4, 5},
                {3, 5, 6, 4, 6}
            };

            int res = ds.Calculate(matrix);

            Assert.AreEqual(44, res);
        }
    }
}