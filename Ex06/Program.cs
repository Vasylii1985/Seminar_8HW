int n = 4;
int[,] sqareMatrix = new int[n, n];
int[,] array = new int[n, n];
int number = 1;
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n - i; j++) array[i, j] = number++;
    for (int k = i + 1; k < n - i; k++) array[k, n - 1 - i] = number++;
    for (int j = n - 2 - i; j >= i; j--) array[n - 1 - i, j] = number++;
    for (int k = n - 2 - i; k > i; k--) array[k, i] = number++;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}    
