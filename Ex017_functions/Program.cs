// Группы методов:

// Вид 1 - ничего не принимают и ничего не возвращают
// void Method1()
// {
//    Console.WriteLine("Автор...");
// }
// Method1(); (верно)
// Method1; (неверно)

// Вид 2 - что-то принимают и ничего не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method2.1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
// {
//     Console.WwriteLine(msg);
//     i++;
// }
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения", count: 4);
// Method2(count: 4, msg: "Текст сообщения");

// Вид 3 - ничего не принимают, но что-то возвращают
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3;
// Console.WriteLine(year);

// Вид 4 - что-то принимают и что-то возвращают
// string Method4(int count, string s)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + s;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "zZz...");
// Console.WriteLine(res);
