// int [] array = new int []{1, 2, 3, 4, 5};     

// PrintArray(array);
// ReverseArray(array);
// PrintArray(array);

// void ReverseArray(int [] array)                     //revers
// {
   
//     for (int i =0; i < array.Length/2; i++ )
//     {
//         int temp = array[i];
//         array [i] = array[array.Length -1 - i];
//         array[array.Length -1 - i] = temp;
        
//     }
    
// }

// void PrintArray(int [] array)
// {
//      Console.Write($"[{string.Join(", ",array)}]  ");
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


/*
Console.Write("Enter A side -> ");
int A = int.Parse(Console.ReadLine());

Console.Write("Enter B side -> ");
int B = int.Parse(Console.ReadLine());

Console.Write("Enter C side -> ");
int C = int.Parse(Console.ReadLine());

bool Exist = IsTriangleExists(A, B, C);

bool IsTriangleExists(int A, int B, int C)

{
    if (A+B <C)
    {
        return false;
    }
    if (B+C <A)
    {
        return false;
    }
     if (C+A <B)
    {
        return false;
    }
    return true;    
}


Console.WriteLine(Exist);
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
/*
Console.WriteLine("Enter Decimal Number");
int N = int.Parse(Console.ReadLine());
while (N != 0)
{
    Console.Write(N%2);
    N = N/2;
}
*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

/*

Console.WriteLine("Enter Number");
int N = int.Parse(Console.ReadLine());

int [] array = FindFibo(N);
PrintArray(array);

int [] FindFibo(int N)
{
    int [] array = new int [N];
     if(array.Length >0)
    {
        array[0] = 0;
    }
    

    if(array.Length >1)
    {
        array[1] = 1;
    }
    

    for ( int i = 2; i< array.Length; i ++)

    {
        array[i]= array[i -1]+array[i-2];
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.WriteLine(string.Join("," , array));
}

*/

// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// c помощью поэлементного копирования.

int [] array = new int[]{1, 2, 3, 4, 5};
PrintArray(array);
int [] CopiedArr  = CopyArray(array);
PrintArray(CopiedArr);


int [] CopyArray(int [] array)
{
int [] CopiedArr = new int [array.Length];
    for( int i = 0; i< array.Length; i++)
    {
        CopiedArr[i] = array[i];
    }
    return CopiedArr;
}

void PrintArray(int [] array)
{
     Console.Write($"[{string.Join(", ",array)}]  ");
}
