
Console.WriteLine("Введитее число:");
string? input = Console.ReadLine();
int number  = Convert.ToInt32(input);

if(number>100)
{
    Console.WriteLine(input[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}