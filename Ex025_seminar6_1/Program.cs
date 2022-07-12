// Напишите программу, которая перевернёт одномерный массив (последний элемент встанет на первое место
// а первый элемент - на последнее и т.д.)

// Первый вариант решения (переворачиваем почти в конце кода)

// int n;
// Console.Write("Задайте длинну массива: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// var random = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(100, 999);
// }
// Console.Write("Наш массив: ");
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// for (var i = 0; i < array.Length / 2; i++)
// {
//     (array[i], array[array.Length-(i+1)]) = (array[array.Length-(i+1)], array[i]);
// }
// Console.WriteLine("Переворачиваем массив...");
// Console.Write("Получилось: ");
// Console.WriteLine("[" + string.Join(", ", array) + "]");

// Второй вариант решения (переворачиваем в начале кода)

// int[] f(int[] array)
// {
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         (array[i], array[array.Length-(i+1)]) = (array[array.Length-(i+1)], array[i]);
//     }
//     return array;
// }
// int n;
// Console.Write("Задайте длинну массива: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// var random = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(100, 999);
// }
// Console.Write("Наш массив: ");
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine("Переворачиваем массив...");
// Console.Write("Получилось: ");
// Console.WriteLine("[" + string.Join(", ", f(array)) + "]");

// Напишите программу, уоторая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длинны
// Теорема о неравенстве треугольника: длинна каждой стороны треугольника меньше суммы длинн
// двух других сторон

// // Мой вариант
// int a, b, c;
// Console.WriteLine("Задайте сторону 'a': ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте сторону 'b': ");
// b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте сторону 'c': ");
// c = Convert.ToInt32(Console.ReadLine());
// if ((a + b) <= c || (b + c) <= a || (c + a) <= b) Console.WriteLine("С такими сторонами треугольник невозможен");
// else Console.WriteLine("Треугольник получится");

// // Вариант преподавателя (с помощью функции)
// string f(int a, int b, int c)
// {
//     if ((a + b) > c && (b + c) > a && (c + a) > b)
//         return "Треугольник может существовать";
//     return "Треугольник невозможен";
// }
// int a, b, c;
// Console.WriteLine("Задайте сторону 'a': ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте сторону 'b': ");
// b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте сторону 'c': ");
// c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(a, b, c));

// Вариант одногрупника (с помощью массива)непонятная ошибка!
string f(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        //Console.WriteLine("Введите {0} сторону предполагаемого треугольника: ", i + 1);
        col[i] = Convert.ToInt32(Console.ReadLine());
    }
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] <= (col[col.Length - i] + col[col.Length - i - 1]))
            count++;
    }
    if (count >=3)
        return "Треугольник может существовать";
    return "Треуголььник невозможен";
}
int[] array = new int[3];
Console.WriteLine(f(array));
