using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KruchininEP.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 0;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(0, res);
            
        }
    }
}
