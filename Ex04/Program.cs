//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.//
int[,] CreateMatrixMxN(int m, int n)
{
    int[,] matrixFromUser = new int[m, n];

    for (int i = 0; i < matrixFromUser.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFromUser.GetLength(1); j++)
        {
            matrixFromUser[i, j] = new Random().Next(1, 10);
        }
    }
    return matrixFromUser;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix2.GetLength(1) == matrix1.GetLength(0)) return true;
    return false;
}

int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            for (int q = 0; q < matrix2.GetLength(1); q++)
            {
                newMatrix[i, q] += matrix1[i, j] * matrix2[j, q];
            }
        }
    }
    return newMatrix;

}
int[,] firstMatrix = CreateMatrixMxN(3, 3);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreateMatrixMxN(3, 3);
PrintMatrix(secondMatrix);
Console.WriteLine();
bool check = CheckMatrix(firstMatrix, secondMatrix);

if (check == true)
{
    int[,] c = Multiply(firstMatrix, secondMatrix);
    PrintMatrix(c);
}

