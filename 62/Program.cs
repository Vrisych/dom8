// Напишите программу, которая заполнит спирально массив 4 на 4. Nope :^)
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк, затем столбцов. Программа заполнит его по спирали");
int Array0 = int.Parse(Console.ReadLine());
int Array1 = int.Parse(Console.ReadLine());
int [,] Martix = new int [Array1,Array0];
int [,] MaxCount = {{0, Array1}, {0, Array0}};
void GoRight (int [,]array, int [,] xy, int Count)
{
    if (xy[1,0]==xy[1,1]) PrintArray(Martix);
    else
    {
        for (int i = xy[1,0]; i<xy[1,1]; i++)
        {
            Count=Count+1;
            array [xy[0,0],i]= Count;
        }
        xy[0,0] = xy[0,0]+1;
        GoDown(array, xy, Count);
    }
    
}
void GoDown (int [,]array, int [,] xy, int Count)
{
    if (xy[0,0]==xy[0,1]) PrintArray(Martix);
    else
    {
        for (int i = xy[0,0]; i<xy[0,1]; i++)
        {
            Count=Count+1;
            array [i,xy[1,1]-1]= Count;
        }
        xy[1,1] = xy[1,1]-1;
        GoLeft(array, xy, Count);
    }
    
}
void GoLeft (int [,]array, int [,] xy, int Count)
{
    if (xy[0,0]==xy[0,1]) PrintArray(Martix);
    else
    {
        for (int i = xy[1,1]-1; i>=xy[1,0]; i--)
        {
            Count=Count+1;
            array [xy[0,1]-1,i]= Count;
        }
        xy[0,1] = xy[0,1]-1;
        GoUp(array, xy, Count);
    }
    
}
void GoUp (int [,]array, int [,] xy, int Count)
{
    if (xy[1,0]==xy[1,1]) PrintArray(Martix);
    else
    {
        for (int i = xy[0,1]-1; i>=xy[0,0]; i--)
        {
            Count=Count+1;
            array [i,xy[1,0]]= Count;
        }
        xy[1,0] = xy[1,0]+1;
        GoRight(array, xy, Count);
    }
    
}
void PrintArray (int [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            if (array[i,n]<10) Console.Write($"0{array[i,n]}  ");
            else Console.Write($"{array[i,n]}  ");
        }
        Console.WriteLine();
    }
}
GoRight(Martix, MaxCount, 0);
