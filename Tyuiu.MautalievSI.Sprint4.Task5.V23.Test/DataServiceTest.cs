using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint4.Task5.V23.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task5.V23.Test
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
                { -4, -1,  2,  5,  8 },
                {  3, -2,  7, -3,  1 },
                {  0,  4, -4,  6, -1 },
                {  8, -3,  5,  2, -2 },
                { -1,  7,  3, -4,  4 }
            };

            int[,] wait = new int[,]
            {
                { 0, 0, 2, 5, 8 },
                { 3, 0, 7, 0, 1 },
                { 0, 4, 0, 6, 0 },
                { 8, 0, 5, 2, 0 },
                { 0, 7, 3, 0, 4 }
            };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}