using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RubankoGV.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries = Math.Pow((Math.Sin(0.1) + 1), 7);

            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
