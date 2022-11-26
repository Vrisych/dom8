// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк, затем столбцов. Программа расположит элементы каждой строки по убыванию.");
int Array0 = int.Parse(Console.ReadLine());
int Array1 = int.Parse(Console.ReadLine());
double [,] Martix = new double [Array0,Array1];
double [,] FixMartix = new double [Array0,Array1];

void FillArray (double [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Random rand = new Random();
            array[i,n] = rand.Next(0,10);
        }
    }
}
void PrintArray (double [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Console.Write($"{array[i,n]}  ");
        }
        Console.WriteLine();
    }
}
void RearrangeArray (double [,] array)
{
    
    for (int i = 0; i <array.GetLength(0); i++)
    {
        
        for (int l=0; l<array.GetLength(1); l++)
        {
            int max = l;
            for (int n = l+1; n <array.GetLength(1); n++)
            {
                if (array[i,n]>array[i,max])  max = n;
            }
        double sr = array[i,l];
        array[i,l] = array[i,max];
        array [i,max] = sr;
        }
    }
}
FillArray(Martix);
PrintArray(Martix);
Console.WriteLine("");
RearrangeArray(Martix);
PrintArray(Martix);