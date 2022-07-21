int[,] CreateMatr(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

//     // Меняем местами первую и последнюю строку массива
// void PrintMatr(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         (matrix[0, j], matrix[matrix.GetLength(0) - 1, j]) 
//         = (matrix[matrix.GetLength(0) - 1, j], matrix[0, j]);
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

void PrintMatr(int[,] matrix)
{
    Console.WriteLine();
    if (matrix.GetLength(0) == matrix.GetLength(1))
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j > i)
            {
                (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
            }
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    else Console.WriteLine("Замена невозможна.");
}
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(m, n));
