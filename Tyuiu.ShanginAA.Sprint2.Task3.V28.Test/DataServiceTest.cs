using Tyuiu.ShanginAA.Sprint2.Task3.V28.Lib;

namespace Tyuiu.ShanginAA.Sprint2.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 1.881;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = -5;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -12;
            double wait = 0.003;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -50;
            double wait = -549.86;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}