//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Enter a three-digit number");
int A = int.Parse(Console.ReadLine());

A = (A / 10) % 10;
Console.WriteLine("The second digit of the nimber is: " + A); 