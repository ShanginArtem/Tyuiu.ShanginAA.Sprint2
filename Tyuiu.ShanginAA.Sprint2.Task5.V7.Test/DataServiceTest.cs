using Tyuiu.ShanginAA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ShanginAA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 14;
            Assert.AreEqual(ds.FindMonthName(1990, n), "Февраль");

        }
    }
}