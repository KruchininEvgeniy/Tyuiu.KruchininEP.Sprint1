using Tyuiu.KruchininEP.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KruchininEP.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 50;
            double res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(10, res);
        }
    }
}