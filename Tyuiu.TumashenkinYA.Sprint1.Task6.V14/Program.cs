using Tyuiu.TumashenkinYA.Sprint1.Task6.V14.Lib;
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

        Console.WriteLine("*Написать программу, пользователь вводит текст. Проверить, что в строке   *");
        Console.WriteLine("*находятся только русские и строчные буквы.                               *");

        DataService ds = new DataService();

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите строку: ");
        string value = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var result = ds.CheckLowerCaseRusLetters(value);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}