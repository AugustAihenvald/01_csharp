/* На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание
Метод строки ToCharArray() не использовать.
Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] */

using System.Reflection;

char[] CreateCharToString(string str)
{
    char[] arr = new char[str.Length];
    
    for (int i = 0; i < str.Length; i++)
    {
       arr[i]= str[i]; 
    }
    return arr;
}

void PrintArr(char[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i<arr.Length-1)
       {
            Console.Write($"'{arr[i]}', ");
       }
       else
       {
        Console.Write($"'{arr[i]}'");
       } 
    }
    Console.Write("]");
}
string str = "Hello!";
char[] result = CreateCharToString(str);
PrintArr(result);