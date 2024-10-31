using Tyuiu.RubankoGV.Sprint3.Task2.V9.Lib;
namespace Tyuiu.RubankoGV.Sprint3.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Переменная n = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

           Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
