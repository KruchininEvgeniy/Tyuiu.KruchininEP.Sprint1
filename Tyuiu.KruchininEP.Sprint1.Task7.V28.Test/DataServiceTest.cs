using Tyuiu.KruchininEP.Sprint1.Task7.V28.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validExprisson()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double wait = 6.444;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}