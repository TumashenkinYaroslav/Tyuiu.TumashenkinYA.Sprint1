using Tyuiu.TumashenkinYA.Sprint1.Task4.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Class Math                                                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
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

        Console.WriteLine("Введите число x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var result = ds.Calculate(x, y);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}