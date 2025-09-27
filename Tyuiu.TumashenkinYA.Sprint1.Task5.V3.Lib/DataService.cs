using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TumashenkinYA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string x = Convert.ToString(k);
            string reversed = new string(x.Reverse().ToArray());
            return int.Parse(char.ToString(reversed[2]));
        }
    }
}
