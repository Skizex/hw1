
Console.WriteLine("Введитее трехзначное число:");
string? input = Console.ReadLine();
int number  = Convert.ToInt32(input);

if(number>99 && number<999)
{
    Console.WriteLine($"{input[1]}");
}
else
{
    Console.WriteLine("Необходимо ввести   трехзначное число!");
    
}



