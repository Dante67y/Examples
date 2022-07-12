// Двумерные массивы

// // Пишем тип данных (сейчас используем string), в квадратных скобках обязательно запятую,
// // она нам и указывает что будет две размерности (одна размерность это строки, вторая - столбцы)
// // table - как наименование массива, далее задаём количество строк и столбцов в нашем массиве
// string[,] table = new string[2, 5];
// // В данном случае добавляем прямоугольную таблицу чисел, в математике её называют матрицей
// // В квадратных скобках так же указываем количество строк и столбцов (первая и вторая цифры)
// int[,] matrix = new int[5, 8];

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums ++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

int[,] matrix = new int[3, 4];
void PrintArray(int[,] mat)
{
    // Чтобы рками постоянно не прописывать и не исправлять количество строк и столбцов, проще записать так
    // matrix.GetLength(0) для строк и matrix.GetLength(1) для столбцов
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}
// void FillArray(int[,] mat);
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             mat[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
PrintArray(matrix);
