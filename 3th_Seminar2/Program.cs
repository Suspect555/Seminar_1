
Console.WriteLine("enter NumberOfQuarter");
int num = int.Parse(Console.ReadLine());

string result = GetCorArr(num);

// if (result == 0)
// {
//     Console.WriteLine("x or y equal zero. data is wrong");
//     return;
// }

Console.WriteLine(result);

string GetCorArr(int num)
{
    if(num == 1)
    {
        return "x>0 && y>0";

    } 
    if (num == 2)
    {

    return "y>0 && x<0";
    }
    if (num == 3)
    {

    return "x<0 && y<0";
    }

    if (num == 4)
    {

    return "x>0 && y <0";
    }
    return "invalid Quarter";
}