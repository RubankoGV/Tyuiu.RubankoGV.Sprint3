using Tyuiu.RubankoGV.Sprint3.Task0.V4.Lib;
namespace Tyuiu.RubankoGV.Sprint3.Task0.V4.Test
{
    public class DataServiceTest
    {
        [Test]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 2;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 1.946;
            
            Assert.AreEqual(wait, res);
        }
    }
}