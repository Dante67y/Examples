// int x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0) Console.WriteLine("1 четверть");
// if (x < 0 && y > 0) Console.WriteLine("2 четверть");
// if (x > 0 && y < 0) Console.WriteLine("3 четверть");
// if (x < 0 && y < 0) Console.WriteLine("4 четверть");

// int n;
// n = Convert.ToInt32(Console.ReadLine());
// if (n > 0 && n < 5){
//     if (n == 1){
//         Console.WriteLine("x = (0, +~)");
//         Console.WriteLine("y = (0, +~)");
//     }
//     if (n == 2){
//         Console.WriteLine("x = (-~, 0)");
//         Console.WriteLine("y = (0, +~)");
//     }
//     if (n == 3){
//         Console.WriteLine("x = (0, +~)");
//         Console.WriteLine("y = (-~, 0)");
//     }
//     if (n == 4){
//         Console.WriteLine("x = (-~, 0)");
//         Console.WriteLine("y = (-~, 0)");
//     }
// }
// else Console.WriteLine("Такой четверти НЕТ!");

// double x, y, x1, y1, len;
// x = Convert.ToDouble(Console.ReadLine());
// y = Convert.ToDouble(Console.ReadLine());
// x1 = Convert.ToDouble(Console.ReadLine());
// y1 = Convert.ToDouble(Console.ReadLine());
// len = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
// Console.WriteLine(len);

// int n;
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(i * i);
// }

int n, i = 1;
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    Console.WriteLine(i * i);
    i++;
}
