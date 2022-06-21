//Task34
//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2

/*void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int[] numbers = new int[12];
FillArr(numbers);
PrintArr(numbers);

int Positive = 0; 
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 ==0  )
    {
        Positive++;
    }
}
Console.WriteLine("Number of positive numbers: " + Positive);*/



////////////////////////////////////////////////////////////////////////////
//Task36

//Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-9, 10);
    }
}

int[] numbers = new int[10];
FillArr(numbers);
PrintArr(numbers);

int Sum = 0;
for (int i = 1; i < numbers.Length; i +=2)
{ 
    Sum += numbers[i];
}

Console.WriteLine("Summ of numbers with odd index: " + Sum);*/

///////////////////////////////////////////////////////////////////////////////
//Task38

//Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

/*void PrintArray(double[] array)
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
Console.WriteLine("Difference between max and min element: " + result);*/