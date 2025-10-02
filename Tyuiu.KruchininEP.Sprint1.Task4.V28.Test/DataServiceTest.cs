using Tyuiu.KruchininEP.Sprint1.Task4.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = 0.007;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}