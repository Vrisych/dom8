// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
Console.WriteLine("Введите желаемый размер трехмерного массива, сначала количество строк, столбцов, а затем глубина через enter. Программа создаст и выведет массив с неповторяющимися двузначными числами вместе с координатами");
int Array0 = int.Parse(Console.ReadLine());
int Array1 = int.Parse(Console.ReadLine());
int Array2 = int.Parse(Console.ReadLine());
int [,,] Matrix = new int [Array0,Array1,Array2];

void CheckArray(int [,,] array, int a, int b, int c)
{
    int y= array.GetLength(1);
    int z= array.GetLength(2);
    for (int l= 0; l<a+1; l++)
    {
        if (l == a) y = b+1;
        for (int m =0; m<y; m++)
        {
            if (l == a && m == b) z=c;
            for (int n =0 ; n<z; n++)
            {
                if (array[l,m,n] == array[a,b,c]) FillArray(array, a, b, c );

            }
        }
    }
}

void FillArray (int [,,] array, int x, int y, int z)
{
    Random rand = new Random();
    for (int a = x; a <array.GetLength(0); a++)
    {
        for (int b = y; b <array.GetLength(1); b++)
        {
            for (int c = z; c<array.GetLength(2); c++)
            {
                array[a, b, c] = rand.Next(10,100);
                CheckArray(array, a, b, c);
            }
        }
    }
}
void PrintArray (int [,,] array)
{
    for (int x = 0; x <array.GetLength(0); x++)
    {
        for (int y = 0; y <array.GetLength(1); y++)
        {
            for (int z=0; z<array.GetLength(2); z++)
            {
                Console.Write($"{array[x,y,z]} ({x}, {y}, {z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
if (Array0*Array1*Array2 >90) Console.WriteLine("Массив слишком велик, недостаточно двузначных чисел для заполнения.");
else
{
    FillArray(Matrix, 0,0,0);
    PrintArray(Matrix);
}