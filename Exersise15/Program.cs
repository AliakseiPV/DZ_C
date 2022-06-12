//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.WriteLine("Write the number of the day of the week from 1 to 7");
int A = int.Parse(Console.ReadLine());

if(A == 1)
{
    Console.WriteLine("it is Monday");
}
else if(A == 2)
    {
        Console.WriteLine("it is Tuesday");
    }
    else if(A == 3)
        {
            Console.WriteLine("it is Wednesday");
        }
        else if(A == 4)
            {
                Console.WriteLine("it is Thursday");
            }
            else if(A == 5)
                {
                    Console.WriteLine("it is Friday");
                }
                else if(A == 6)
                    {
                        Console.WriteLine("it is the Weekend - Saturday");
                    }
                    else if(A == 7)
                        {
                            Console.WriteLine("it is the Weekend - Sunday");
                        }else
                            {
                                Console.WriteLine("Write the number from 1 to 7, try again!");
                            }