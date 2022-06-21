//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2

void PrintArr(int[] array)
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
Console.WriteLine("Number of positive numbers: " + Positive);