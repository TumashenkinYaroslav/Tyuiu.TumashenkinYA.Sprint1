using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TumashenkinYA.Sprint1.Task4.V7.Lib
{
    public class DataService : ISprint1Task1V7
    {
        public double Calculate(double x, double y)
        {
            double Number = (1 + Math.Sqrt(x * y)) / Math.Pow(x - 3 * y, 2);
            return Math.Round(Number, 3);
        }
    }
}
