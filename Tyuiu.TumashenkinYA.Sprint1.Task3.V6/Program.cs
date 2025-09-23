using Tyuiu.TumashenkinYA.Sprint1.Task3.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Арифметические операторы в C#                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #6                                                             *");
        Console.WriteLine("* Выполнил:  Тумашенкин Ярослав Анатольевич | ПКТб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
        Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");

        DataService ds = new DataService();

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите растояние до дачи: ");
        double  distance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите расход бензина: ");
        double  gasFlow= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите цену литра бензина : ");
        double  gasPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var result = ds.TravelCost(distance, gasFlow, gasPrice);
        Console.WriteLine("Поездка на дачу туда и обратно обойдётся в " + result + " руб.");
        Console.ReadKey();



    }
}