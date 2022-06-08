//Задача 2: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Write first number");
string numberA = Console.ReadLine();
int A = Convert.ToInt32(numberA);

Console.WriteLine("Write second number");
string numberB = Console.ReadLine();
int B = Convert.ToInt32(numberB);
int max;


if(A > B)
{
    max = A;
    Console.WriteLine("Max number: " + max);
}
else
{
    max = B;
    Console.WriteLine("Max number: " + max);
}

if(A == B)
{
    Console.WriteLine("The numbers are equal");
}