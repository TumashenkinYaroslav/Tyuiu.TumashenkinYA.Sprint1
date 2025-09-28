using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TumashenkinYA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            
            bool allLowercase = true;
            foreach (char c in value)
            {
                if (!Char.IsLower(c))
                {
                    allLowercase = false; break;
                }
            }
            return allLowercase;
        }

    }
}
