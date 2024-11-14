using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RubankoGV.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string str = value;
            string lib = "qwertyuiopasdfghjklzxcvbnm!.,? ";
            foreach (char i in value)
            {
                if (lib.Contains(i))
                {
                    string i1 = i.ToString();
                    str = str.Replace(i1, "");
                }
                else
                {
                    continue;
                }
            }
            return Int32.Parse(str);

        }
    }
}
