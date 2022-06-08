//Задача 6: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Write first number");
string numberA = Console.ReadLine();
int A = Convert.ToInt32(numberA);

int r = A % 2;

if(r == 0)
{
    Console.WriteLine("This number is even");
}
else 
{
    Console.WriteLine("This number is odd");
}