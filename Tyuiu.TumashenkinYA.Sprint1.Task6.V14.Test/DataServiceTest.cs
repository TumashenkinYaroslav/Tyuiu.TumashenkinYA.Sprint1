using Tyuiu.TumashenkinYA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.TumashenkinYA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "абвГд";
            DataService ds = new DataService();
            var result = ds.CheckLowerCaseRusLetters(value);
            bool res = result == true;
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
