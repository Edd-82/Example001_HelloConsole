Console.Write("input name: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}