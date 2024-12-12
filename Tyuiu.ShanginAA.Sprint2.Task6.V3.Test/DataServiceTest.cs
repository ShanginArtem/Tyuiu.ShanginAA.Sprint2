using Tyuiu.ShanginAA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.ShanginAA.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            string wait = "среда";
            Assert.AreEqual(wait, ds.FindDayName(x));
        }
    }
}