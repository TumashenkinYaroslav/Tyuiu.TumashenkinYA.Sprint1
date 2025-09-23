using Tyuiu.TumashenkinYA.Sprint1.Task2.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Арифметические операторы в C#                                           *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил:  Тумашенкин Ярослав Анатольевич | ПКТб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
        Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value;

        Console.WriteLine("Введите температуру в градусах Цельсия: ");
        value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        Console.WriteLine("Температура в градусах Кельвина: " + ds.ConvertCelsiusToKelvin(value));
        Console.ReadKey();
    }
}