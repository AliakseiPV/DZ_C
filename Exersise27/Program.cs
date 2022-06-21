//Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int func(int N)
{ 
    int result = 0;
    int A = N.ToString().Length;
    int[] arr = new int[A]; 
    
    for(int i = 0; i < A; i++)
    {
        arr[i] = N % 10;
        N = N / 10;
        Console.WriteLine(arr[i]);
    }

    int L = arr.Length;
    for(int i = 0; i < L; i++)
    {
        result += arr[i]; 
    }

    return result;
}

Console.WriteLine("Write the number N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("sum: " + func(N));

