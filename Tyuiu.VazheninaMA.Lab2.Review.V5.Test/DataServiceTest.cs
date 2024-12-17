using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VazheninaMA.Lab2.Review.V5.Lib;

namespace Tyuiu.VazheninaMA.Lab2.Review.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMassFunction1()
        {
            double[] array = { -2.82,
            15,
            0.4,
            1.9,
            2.6,
            0.09,
            5.62,
            -5.22,
            -0.96,
            -7.4
            };
            var lib = new DataService();
            CollectionAssert.AreEqual(array, lib.GetMassFunction(0, 10));
        }
    }
}
