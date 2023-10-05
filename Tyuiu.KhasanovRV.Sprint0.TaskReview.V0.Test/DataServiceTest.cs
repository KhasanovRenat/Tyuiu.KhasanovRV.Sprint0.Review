using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KhasanovRV.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int x = 1, y = 2, z = 3;
            var rez = ds.Calc(x, y, z);
            Assert.AreEqual(30, rez);


            
        }
    }
}
