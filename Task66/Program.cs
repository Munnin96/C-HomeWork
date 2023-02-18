// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int m, int n)
{
    if (m == n)
        return 0;
    else return m + SumNumbers(m + 1, n);
}
int sum = SumNumbers(number1, number2 + 1);
Console.WriteLine($"{sum}");
