//Задача 4: Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Write first number");
string numberA = Console.ReadLine();
int A = Convert.ToInt32(numberA);

Console.WriteLine("Write second number");
string numberB = Console.ReadLine();
int B = Convert.ToInt32(numberB);

Console.WriteLine("Write third number");
string numberC = Console.ReadLine();
int C = Convert.ToInt32(numberC);

int max = A;

if(A > B && A > C)
{
    max = A;
} else if(B > A && B > C)
        {
            max = B;
        }
        else if(C > A && C > B)
            {
                max = C;
            }
Console.WriteLine("Max number: " + max);