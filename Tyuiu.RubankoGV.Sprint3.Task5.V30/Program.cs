using Tyuiu.RubankoGV.Sprint3.Task5.V30.Lib;
namespace Tyuiu.RubankoGV.Sprint3.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Решить уравнение, при помощи цикла. Где X=2                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int x5 = Convert.ToInt32(Console.ReadLine());



            var result = ds.GetSumSumSeries(x1, x2, x3, x4, x5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
