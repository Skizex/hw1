
Console.WriteLine("Введите порядковый номер дня недели, чтобы проверить  является ли он выходным");
int number =  Convert.ToInt32(Console.ReadLine());

if(number ==  6  || number  == 7)
{
    Console.WriteLine("Это  выходной");

}
else if (number > 7)
{
    Console.WriteLine("В неделе только семь дней");
}
else
{
    Console.WriteLine("Это рабочий день");
}


