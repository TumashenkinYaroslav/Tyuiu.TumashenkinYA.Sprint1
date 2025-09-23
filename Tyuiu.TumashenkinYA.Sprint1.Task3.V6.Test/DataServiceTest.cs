using Tyuiu.TumashenkinYA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.TumashenkinYA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 67;
            double y = 8.5;
            double z = 6.5;
            double wait = 74.04;
            var res = ds.TravelCost(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}
