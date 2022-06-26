//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Enter numbers separated by commas");
string numbers = Console.ReadLine();
string[] M = numbers.Split(",");

int[] array = new int[M.Length];

for (int i = 0; i < M.Length; i++)
{
    array[i] = Convert.ToInt32(M[i]);
}

PrintArr(array);

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        result = result + 1;
    }
}
Console.WriteLine("Nubers greater then zero: " + result);





