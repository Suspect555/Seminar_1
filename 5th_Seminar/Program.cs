

/*
int [] array =  RandomArray(12);
PrintArray(array);

int sumNegative = CalculateNegativeNumbers(array);
int sum = CalculatePositiveNumbers(array);
Console.WriteLine($"positive summ -> {sum}");
Console.WriteLine($"negative summ -> {sumNegative}");

int [] RandomArray(int length)
{
    int [] array = new int [length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {

      array [i] = rand.Next(-9,10);
    }

  return array;
}

int CalculatePositiveNumbers(int[] array)
{
    int sumPositive = 0;

   for ( var i = 0; i < array.Length; i ++)
     {
      if (array[i] > 0) 
      {
        sumPositive += array[i];
      }
}
return sumPositive;  
}

int CalculateNegativeNumbers(int[] array)
{
    int sumNegative = 0;

   for ( var i = 0; i < array.Length; i ++)
     {
      if (array[i] < 0) 
      {
        sumNegative += array[i];
      }
}
return sumNegative;  
}

void PrintArray(int [] array)
{
     Console.WriteLine(string.Join(", ",array));
}*/


// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
/*
int [] array =  new int [12];

RandomArray(array);
PrintArray(array);
ChangeSings(array);
PrintArray(array);


void RandomArray(int [] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = rand.Next(-9,10);
    }
}

void ChangeSings(int [] array)
{
    for (int i =0; i < array.Length; i ++)
    { 
            array[i] = -array[i]; 
    }
}

void PrintArray(int [] array)
{
     Console.WriteLine(string.Join(", ",array));
}
*/
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

/*
int [] array =  new int [12];
Console.WriteLine("Enter N number");
int N = int.Parse(Console.ReadLine());

RandomArray(array);
bool result = FindNumber(array,N);
Console.WriteLine(result);
PrintArray(array);

void RandomArray(int [] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = rand.Next(-9,10);
    }
}

bool FindNumber(int [] array, int N)
{
    for (int i =0; i < array.Length; i ++)
    { 
        if (array[i] == N)
        {
            return true;
        }
    }    
return false;
}

void PrintArray(int [] array)
{
     Console.WriteLine($"[{string.Join(", ",array)}]");
}
*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*

int [] array =  new int [123];

RandomArray(array);
int elements = FindNumber(array);
PrintArray(array);
Console.WriteLine(elements);

void RandomArray(int [] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = rand.Next(0,100);
    }
}

int FindNumber(int [] array)
{
    int count = 0;

    for (int i =0; i < array.Length; i ++)
    { 
        
        if (array[i] >9 & array[i] < 100)
        {
            count ++;
        }
    }    
return count;
}

void PrintArray(int [] array)
{
     Console.WriteLine($"[{string.Join(", ",array)}]");
}
*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] array =  new int [5];

RandomArray(array);
PrintArray(array);
int [] result = ReverseArray(array);
PrintArray(result);


void RandomArray(int [] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = rand.Next(0,10);
    }
}

int [] ReverseArray(int [] array) // revers
{
    
    int [] result = new int[array.Length/2 + array.Length%2];
    for (var i = 0; i < array.Length/2; i++)
    {
        if (i == (array.Length - 1 - i))
        {
            result [i] = array[i];
            return result;
        }
        else
        {
            result [i] = array [i] * array[array.Length -1 -i];
        }
    
    }
return result;
}

void PrintArray(int [] array)
{
     Console.Write($"[{string.Join(", ",array)}]  ");
}
