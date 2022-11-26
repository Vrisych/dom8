// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк l, затем столбцов m через enter. Размер второго массива m*n, введите n. Программа найдет произведение матриц");
int Array0 = int.Parse(Console.ReadLine());
int Array1 = int.Parse(Console.ReadLine());
int Array2 = int.Parse(Console.ReadLine());
int [,] Martix1 = new int [Array0,Array1];
int [,] Martix2 = new int [Array1,Array2];
int [,] MartixResult = new int [Array0,Array2];

void FillArray (int [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Random rand = new Random();
            array[i,n] = rand.Next(1,10);
        }
    }
}
void PrintArray (int [,] array)
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
int MultipleMatrix (int [,] array1, int [,] array2, int l, int m, int n)
{
    int mul =0;
    if (m<array1.GetLength(1))
    {
        return mul = array1[l,m]*array2[m,n]+MultipleMatrix(array1, array2, l, m+1, n);
    }
    else return 0;
}
FillArray(Martix1);
PrintArray(Martix1);
Console.WriteLine();
FillArray(Martix2);
PrintArray(Martix2);
Console.WriteLine("Произведение матриц равно:");

for (int i = 0; i <Array0; i++)
    {
        for (int n = 0; n <Array2; n++)
        {
            MartixResult [i,n]=MultipleMatrix(Martix1, Martix2, i, 0, n);
        }
    }
PrintArray (MartixResult);