//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int N = EnterNumber("Введите натуральное число N");

int PrintNumbers (int number)
{
    if (number > 1)
    {
        Console.Write(number + " ");
        PrintNumbers(number - 1);
    }
    return 1;
}
Console.WriteLine(PrintNumbers(N));