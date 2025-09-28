using Tyuiu.TumashenkinYA.Sprint1.Task7.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Работа со строками класса String                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #14                                                              *");
        Console.WriteLine("* Выполнил:  Тумашенкин Ярослав Анатольевич | ПКТб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу, которая вычисляет математическое выражение по        *");
        Console.WriteLine("*исходным значениям данных, вводимых пользователем.                       *");

        DataService ds = new DataService();

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("           2                                                               ");
        Console.WriteLine("         7x                 4   5                                          ");
        Console.WriteLine("z = x + ----- + sin(x) + | x - x |                                         ");
        Console.WriteLine("           3                                                               ");
        Console.WriteLine("          x                                                                ");
        Console.WriteLine("* Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var result = ds.Calculate(x);
        Console.WriteLine("z = " + result);
        Console.ReadKey();

    }
}