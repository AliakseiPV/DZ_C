//Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

Console.WriteLine("Summ of numbers with odd index: " + Sum);