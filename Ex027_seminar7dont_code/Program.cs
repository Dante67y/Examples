// Задайте двумерный массив размером "m*n", заполненный случайными целыми числами

int[,] CreateMatr(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
            // matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatr(int[,] matrix)
{
    Console.WriteLine();
    int DiagonalSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // // Возводим в квадрат числа находящиеся по 2м нечётным индексам
            // if (i % 2 == 1 && j % 2 == 1)
            //     matrix[i, j] = matrix[i, j] * matrix[i, j];
            // Складываем числа по диагонали
            if (i == j)
                DiagonalSum = DiagonalSum + matrix[i, j];
            // Console.Write(matrix[i, j] + " ");
        }
        // Console.WriteLine();
    }
    Console.Write("Сумма элементов по диагонали равна: ");
    Console.WriteLine(DiagonalSum);
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(m, n));
