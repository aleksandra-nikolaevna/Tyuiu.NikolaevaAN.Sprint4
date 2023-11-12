using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint4.Task6.V8.Lib;

namespace Tyuiu.NikolaevaAN.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var food = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            var res = ds.Calculate(food);
            var wait = new string[] { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
