// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}
void ReverseArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int tmp = matr[0, i];
        matr[0,i]=matr[matr.GetLength(0) - 1,i];
        matr[matr.GetLength(0) - 1,i] = tmp;
    }
}
void ChangeStrings(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int tmp = matr[i,j];
            matr[i,j]= matr[j,i];
            matr[j,i]= tmp;

        }
    }
}

int [,] matrix = new int[3,3];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
ChangeStrings(matrix);
ReverseArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}

void ChangeStrings(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            int tmp = matr[i,j];
            matr[i,j]= matr[j,i];
            matr[j,i]= tmp;

        }
    }
}

int [,] matrix = new int[3,3];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
ChangeStrings(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза




void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}


Dictionary<int,int> CountNumbers(int[,] matr)
{
    Dictionary<int,int> dic = new Dictionary<int,int>();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(!dic.TryAdd(matr[i,j],1))
            {
                dic[matr[i,j]] +=1;
            }
        }
    } return dic;
}

int [,] matrix = new int[2,10];


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Dictionary<int,int> result = CountNumbers(matrix);
foreach (var raw in result)
{
     Console.WriteLine($"цифра {raw.Key}  встречается {raw.Value}  раза  ");
}