using Tyuiu.TumashenkinYA.Sprint1.Task5.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Class Math                                                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
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

        Console.WriteLine("Введите число k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var result = ds.Calculate(k);
        Console.WriteLine("h = " + result);
        Console.ReadKey();
    }
}