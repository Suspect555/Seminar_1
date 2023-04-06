
// for (int i = 2; i <= 10; i ++)
// {
//     for (int j = 2; j <= 10; j ++)
//     {
//         Console.WriteLine($'{i} x {j} = {i * j}');
//     }
//     Console.WriteLine();
// } 


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к'' заменить большими “К'',
// а большие “С'' маленькими “с''.
// Ясна ли задача?

// string text = "— Я думаю, — Сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом Согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
    
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text [i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// Console.WriteLine(text);
// Console.WriteLine();

// string newText = Replace(text, ' ', '|' );
// newText = Replace(newText, 'к', 'К' );
// newText = Replace(newText, 'С', 'с' );
// Console.WriteLine(newText);


int[] arr = {9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 2, 5};


void PrintArray(int[] array)
{ 
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}    

void SectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i ++)
    { 
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j ++) 
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        

        int temporary = array[i];
        array [i] = array[minPosition];
        array [minPosition] = temporary;   
    }
}



PrintArray(arr);
SectionSort(arr);
PrintArray(arr);
