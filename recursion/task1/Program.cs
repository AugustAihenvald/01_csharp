
int Fact(int n)
{
    if (n == 1 || n ==0)
    {
       return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}
Console.WriteLine(Fact(5));

//f11 шаг заходом
// F10 шаг с обходом
//F5 продолжение