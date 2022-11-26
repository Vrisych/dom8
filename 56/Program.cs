// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк, затем столбцов. Программа найдет строку с наименьшей суммой элементов");
int Array0 = int.Parse(Console.ReadLine());
int Array1 = int.Parse(Console.ReadLine());
double [,] Martix = new double [Array0,Array1];

void FillArray (double [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Random rand = new Random();
            array[i,n] = rand.Next(10,100);
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
void LessString (double [,] array)
{
    double [] Sum = new double [array.GetLength(0)];
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Sum [i] = Sum[i] + array[i,n];
        }
    }
    int min = 0;
    for (int k =1; k<Sum.GetLength(0); k++)
    {
        if (Sum [k]< Sum[min]) min = k;
    }
    Console.Write($"Строка с минимальной суммой элементов - {min+1}, сумма равна - {Sum[min]}");
}
FillArray(Martix);
PrintArray(Martix);
Console.WriteLine("");
LessString(Martix);