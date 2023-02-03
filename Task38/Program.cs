// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) - min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

double MaxNumber(double[] arr)
{
    double maxnumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxnumber < arr[i]) maxnumber = arr[i];
    }
    return maxnumber;
}
double MinNumber(double[] arr)
{
    double minnumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minnumber > arr[i])
        {
            minnumber = arr[i];
        }
    }
    return minnumber;
}

double[] massive = CreateArrayRndInt(10,1,100);
PrintArray(massive);
double maxnumber = MaxNumber(massive);
double minnumber = MinNumber(massive);
double result = maxnumber - minnumber;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {result}");

