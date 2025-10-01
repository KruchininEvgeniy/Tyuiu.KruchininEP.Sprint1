using Tyuiu.KruchininEP.Sprint1.Task3.V17.Lib;
namespace Tyuiu.KruchininEP.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 1.028;
            bool result = ds.ZeroCheck(number);
            Assert.IsTrue(result);
        }
    }
}