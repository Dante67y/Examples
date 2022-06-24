Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Сима")
{
    Console.WriteLine("Ура, это же СИМА!");
}
else
{
    Console.Write("Првиет, ");
    Console.WriteLine(username);
}