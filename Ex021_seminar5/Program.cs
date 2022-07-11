﻿// Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма поолжительных чисел будет равна 29, а сумма
// отрицательных равно -20

// int[] array = new int[12];
// int[] sum = new int[2];
// void FillArray(int[] collection, int[] sum){
//     for (int i = 0; i < collection.Length; i++){
//         array[i] = new Random().Next(-9, 10);
//         if (array[i] > 0) sum[0] = sum[0] + array[i];
//         else sum[1] = sum[1] + array[i];
//     }
// }
// FillArray(array, sum);
// Console.WriteLine("Суммы положительных цифр = {0} и отрицательных = {1}", sum[0], sum[1]);


// Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные и наоборот(которая задаёт массив из 4х элементов от "-9" до "9" и меняет знаки каждого
// элемента: "+" на "-" и наоборот)

// // задаём массив на [x] элементов
// int[] array = new int[4];
// // заполняем заданный массив (array.Lenght - длинна массива, тут можно было написать только "4",
// // так как мы уже задали длинну нашего массива)
// for (int i = 0; i < array.Length; i++){
// // указываем диапазон чисел, которыми заполнится наш массив
//     array[i] = new Random().Next(-9, 10);
// // или можно предоставить такую возможность пользователю
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Введите 4 числа:");
// // выводим на экран получившийся массив(Join позволяет выводить массив без использования циклов)
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// // умножаем каждый элемент массива на "-1" чтобы поменять у них знак
// for (int i = 0; i < array.Length; i++){
//     array[i] = array[i] * (-1);
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

// // задаём массив на [x] элементов
// int[] array = new int[5];
// // заполняем заданный массив (array.Lenght - длинна массива, тут можно было написать только "4",
// // так как мы уже задали длинну нашего массива)
// for (int i = 0; i < array.Length; i++){
// // указываем диапазон чисел, которыми заполнится наш массив
// //    array[i] = new Random().Next(-9, 10);
// // или можно предоставить такую возможность пользователю
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine("Введите число:");
// int n;
// bool log = false;
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < array.Length; i++){
//     if (n == array[i]){
//         log = true;
//         break;
//     }
// }
// if (log){
//     Console.WriteLine("Yes");
// }
// else{
//     Console.WriteLine("No");
// }

// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значение которых лежат в отрезке [10, 99]

int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine(count);
