using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint4.Task0.V1.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            int res = ds.GetSumEvenArrEl(array);

            Assert.AreEqual(20, res);
        }
    }
}