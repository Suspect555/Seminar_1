
Console.WriteLine("enter x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("enter y");
int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarters(x,y);

if (result == 0)
{
    Console.WriteLine("x or y equal zero. data is wrong");
    return;
}

Console.WriteLine(result);

int GetNumberOfQuarters(int x, int y)
{
    if(x>0 && y>0)
    {
        return 1;

    } 
    if (y>0 && x<0)
    {

    return 2;
    }
    if (x<0 && y<0)
    {

    return 3;
    }

    if (x>0 && y <0)
    {

    return 4;
    }
    return 0;
}

