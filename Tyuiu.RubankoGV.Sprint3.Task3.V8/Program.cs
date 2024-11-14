using Tyuiu.RubankoGV.Sprint3.Task3.V8.Lib;
namespace Tyuiu.RubankoGV.Sprint3.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая удаляет буквы и знаки      *");
            Console.WriteLine("* из строки, а после возвращает число.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            string s = "vc, x12fc fc!e";
            Console.WriteLine("* Строка: " + s);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.ConvertStringToInt(s));

        }
    }
}
