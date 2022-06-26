//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

/*void PrintArr(int[] array)
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
Console.WriteLine("Nubers greater then zero: " + result);*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 43. Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 =
//9 -> (-0,5; 5,5)

Console.WriteLine("Enter b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = double.Parse(Console.ReadLine());

if(k1 == k2)
{
    Console.WriteLine("Try again k1 cant be equal k2");
}
else
{
double x = (b2 - b1) / (k1 - k2); 
double y = k1 * x + b1;

Console.WriteLine("Point of intersection of lines: (" + x + ";" + y + ")");
}

