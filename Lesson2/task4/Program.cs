// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>=100 || num<=-100)
{
    while (num>999 || num< -999)
    {
        num = num /10;
    }
    int result = num % 10;
    Console.WriteLine("Третья цифра слева " + result);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}
