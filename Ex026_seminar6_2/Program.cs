// // Напишите программу, которая будет преобразовывать десятичное число в двоичное

// // Перевод числа в двоичную систему исчисления(0=0, 1=1, 2=10...10=1010...)

// int count = 0, x, n = Convert.ToInt32(Console.ReadLine());
// // Добавляем динамический массив через функцию List (нужно для разворота результата, потому что без такого
// // массива терминал выдаст 0101)
// List<int> array = new List<int>();
// while (n > 0)
// {
//     x = n % 2;
//     array.Add(x);
//     count++;
//     // Console.Write(x);
//     n = n /= 2;
// }
// for (int i = count - 1; i >= 0; i--)
// {
//     Console.Write(array[i]);
// }

// Напишите программу, которая будет выводить первые "N" чисел Фибоначчи

// // Мой вариант (скопировал с лекции и отредактировал)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// int n;
// Console.Write("Введите число: ");
// n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Высчитываем число Фибоначчи заданного числа:");
// for (int i = 1; i <= (n + 1); i++)
// {
//     Console.Write($"f({i - 1}) = {Fibonacci(i)}");
//     Console.Write("; ");
// }

// // Вариант преподавателя (Денис)
// int a0 = 0, a1 = 1, a2;
// int n;
// Console.Write("Введите число: ");
// n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Высчитываем число Фибоначчи заданного числа:");
// for (int i = 0; i < n; i++)
// {
//     a2 = a0 + a1;
//     a0 = a1;
//     a1 = a2;
//     Console.Write(a2);
//     Console.Write(" ");
// }

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] arr1 = new int[] {1, 2, 56, 0 -10};
int[] arr2 = new int[arr1.Length];
int x;
for (int i = 0; i < arr2.Length; i++)
{
    x = arr1[i];
    arr2[i] = x;
}
