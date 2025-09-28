using System.Security.Cryptography.X509Certificates;
using Tyuiu.TumashenkinYA.Sprint1.Task7.V19.Lib;
namespace Tyuiu.TumashenkinYA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            var result = ds.Calculate(x);
            double wait = 15.409;
            Assert.AreEqual(wait, result);
        }
    }
}
