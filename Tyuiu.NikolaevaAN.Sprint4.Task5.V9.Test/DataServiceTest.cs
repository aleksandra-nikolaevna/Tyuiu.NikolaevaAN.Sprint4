using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint4.Task5.V9.Lib;

namespace Tyuiu.NikolaevaAN.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -3,-3,-3,-3,-3},{ -1,-1,-1,-1,-1},
            { 0,0,0,0,0},{ 1,1,1,1,1},{ 3,3,3,3,3} };
            int res = ds.Calculate(mas2);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
