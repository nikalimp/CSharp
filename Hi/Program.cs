Console.WriteLine("What's your name?");
string username = Console.ReadLine();

if (username.ToLower() == "Nik")
{
    Console.WriteLine("Good job, man");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}