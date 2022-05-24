//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.//
int[,,] CreateArray3D(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    int element = 10;

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        element += i;
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            element += j;
            for (int q = 0; q < array3D.GetLength(2); q++)
            {
                element += q;
                array3D[i, j, q] = element;
            }
        }
    }
    return array3D;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int q = 0; q < array.GetLength(2); q++)
            {
                Console.Write($"({i},{j},{q}):- {array[i, j, q]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] dimensional = CreateArray3D(3, 3, 3);
PrintArray3D(dimensional);
