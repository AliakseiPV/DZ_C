//Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.

Console.WriteLine("Vvedite piatiznachnoe chislo");
int A = int.Parse(Console.ReadLine());

int a1 = A / 10000;
int a2 = (A / 1000) % 10;
int a4 = (A % 100) / 10;
int a5 = (A % 10);

if(a1 == a5 && a2 == a4)
{
    Console.WriteLine("Chislo " + A + " palindrom");
}
else{
    Console.WriteLine("Chislo " + A + " ne palindrom");
}
