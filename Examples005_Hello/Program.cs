Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же маша!");
}
else
{
    Console.WriteLine($"Привет  {username}" ); 
}