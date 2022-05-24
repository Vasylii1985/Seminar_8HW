 //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.//
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] RandomMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}
int [,] workMatrix(int[,] matrix)
{
    int save = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) -1 -j; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    save = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = save;
                 }
             }
        }
    }
    return matrix;
}
void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
            Console.WriteLine();
    }
}

int[,] matrix = RandomMatrix(n, m);
Console.WriteLine();
printMatrix(workMatrix(matrix));