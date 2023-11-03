using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint4.Task2.V5.Lib;

namespace Tyuiu.NikolaevaAN.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 6, 7, 8, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 36864;
            Assert.AreEqual(wait, res);
        }
    }
}
