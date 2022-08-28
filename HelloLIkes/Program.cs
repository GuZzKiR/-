Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine ();

if(username.ToLower()=="кирилл")
{
    Console.WriteLine ("Здорово братан!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}