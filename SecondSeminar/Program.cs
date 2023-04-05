/*
int a = 5;

int b = 7;

int c = 9; 

int g = 8;

int result1 = Calculate(a,b);
Show(a,b);

int result2 = Calculate(c,g);
Show(c,g);

Console.WriteLine(result1);
Console.WriteLine(result2);

int Calculate(int a, int b)
{
    int result = a * (a * b) -5;

    return result;
}

void Show(int a, int b)
{
    Console.WriteLine($"{a} , {b}");
}
*/

/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98*/

Random random = new Random();

int randomValue = random.Next(100, 1000);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 100;

Console.WriteLine($"{randomValue}");
Console.WriteLine($"{firstDigit}{lastDigit}");

/*Console.WriteLine($"{randomValue}");
Console.WriteLine($"{firstDigit}");
Console.WriteLine($"{lastDigit}");


if (lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}

else
{ 
    Console.WriteLine(firstDigit);
}
*/