int number = int.Parse(Console.ReadLine());

int [] array = ConvertToArray(number);
int [] reversArray = ReverseArray(array);

PrintArray(array);

bool result = Equals(array, reversArray);

Console.WriteLine(result);

void PrintArray(int [] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}


bool Equals(int[] array1,int[] array2)    //сравнение
{
    if (array1.Length != array2.Length)
    {
        return false;
    }
    for (var i = 0; i < array.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }
return true;
}





int [] ReverseArray(int [] array) // revers
{
    int [] result = new int[array.Length];
    for (var i = 0; i < array.Length; i++ )
    {
        result [i] = array[array.Length -1 - i]; // меняет первый с последним
    }
return result;
}


int[] ConvertToArray(int number)          // int into array & revers
{
    int length = GetLengthNumber(number);
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = number % 10;
        number = number /10;
    }
return result;
}

int GetLengthNumber(int number)     // метод подсчета количества символов в int
{
    int length = 0;
    while (number != 0)
    {                                    
        number = number /10;
        length++;
    }
       return length;
}


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120
/*
int a = int.Parse(Console.ReadLine());

int sum = GetSumOfNumbers(a);

Console.WriteLine(sum);

int GetSumOfNumbers(int number)
{
    int sum = 1;
    for (var i = 1; i <= number; i++)
    {
        sum *= i;
    }
    return sum;
}
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
/*
Console.WriteLine("enter array size");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("enter array min");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("enter array max");
int max =int.Parse(Console.ReadLine());

int [] array = RandomArray(size,min,max);
PrintArray (array);

int [] RandomArray(int size,int min,int max)
{
    int [] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)

      array [i] = rand.Next(min,max);
    
  return array;
}
void PrintArray(int [] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
*/