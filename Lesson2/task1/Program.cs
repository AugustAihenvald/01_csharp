

using System.Diagnostics;

Console.WriteLine("Ведите трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num>=100 && Num<=999)
{
    int firstDigit = Num / 100;
    int thirdDigit = Num % 10;

    int result = firstDigit*10+ thirdDigit;

    Console.WriteLine(result);

}
else
{
    Console.WriteLine("Некорректный ввод");
}