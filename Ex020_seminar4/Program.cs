// Напишите прокрамму, которая принимает на вход число "А" и выдаёт сумму чисел от 1 до "А"

// Console.Write("Введите число: ");
// int s = 0, i = 1, x = Convert.ToInt32(Console.ReadLine());
// while (i <= x){
//     s = s + i;
//     i++;
// }
// Console.WriteLine(s);

// Console.Write("Введите число: ");
// int s = 0, x = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= x; i++)
// {
//     s = s + i;
// }
// Console.WriteLine(s);


// Находим факториал числа (произведение всех чисел от 1 до "х")

// Console.Write("Введите число: ");
// int s = 1, x = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= x; i++)
// {
//     s = s * i;
// }
// Console.WriteLine(s);


// Напишите программу, которая на вход принимает число "А" и выдаёт количество цифр в числе

// Console.Write("Введите число: ");
// int i = 0, n = Convert.ToInt32(Console.ReadLine());
// while (n > 0){
//     i++;
//     n = n / 10;
// }
// Console.WriteLine(i);


// Напишите программу, которая выводит массив из8 элементов, заполненных нулями и единицами в случайном порядке

// создаём сам массив
int[] array = new int[8];
// создаём 2 процедуры (void - только процедуры)
// первая процедура принимает коллекцию, находит её длинну и заполняет до тех пор, пока index не станет равен длинне
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);
        //index = index + 1;
        index++;
    }
}
// вторая процедура выводит эти данные
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);

