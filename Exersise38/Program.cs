//Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Math.Round(Math.Round(new Random().NextDouble(),3) * 10, 2);
    }
}

double[] numbers = new double[10];
FillArray(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if(max < numbers[i])
    {
        max = numbers[i];
    }
    if(min > numbers[i])
    {
        min = numbers[i];
    }
}

Console.WriteLine("max elemet: " + max + " min element: " + min);
double result = max - min;
Console.WriteLine("Difference between max and min element: " + result);