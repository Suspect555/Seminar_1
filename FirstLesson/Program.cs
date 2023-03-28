//Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


if (a % b == 0)
{
Console.WriteLine("Yes");
}
else
{
     Console.WriteLine("No");
}
*/

/*Задача No3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/
/*
Console.WriteLine("Enter number of day");

int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Monday");
}
if (a == 2)
{
    Console.WriteLine("Tuesday");
}
if (a == 3)
{
    Console.WriteLine("Wednesday");
}
if (a == 4)
{
    Console.WriteLine("Thursday");
}
if (a == 5)
{
    Console.WriteLine("Friday");
}
if (a == 6)
{
    Console.WriteLine("Saturday");
}
if (a == 7)
{
    Console.WriteLine("Sunday");
}
if (a<1|a>7) 
{ 
    Console.WriteLine("try again");
}
*/
/*Задача No5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/
/*
int N = int.Parse(Console.ReadLine());

int a = -N;

while (a <= N)
{
    Console.Write($"{a}, ");
       a = a + 1;
}
*/
/*Задача No7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6 
782 -> 2
918 -> 8*/
//My solution
/*int a = int.Parse(Console.ReadLine());

int b = a % 10;

Console.WriteLine(b);
*/
//Seminar solution

int a = int.Parse(Console.ReadLine());

if (a<1000&a>99)
{
    Console.WriteLine(a%10);
}
else
{
    Console.WriteLine("Enter correct number");
}






