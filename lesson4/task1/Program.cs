// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

using System.Runtime.Serialization.Formatters;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();

    for (int count = 0; count<size; count++)
    {
        array[count]= rnd.Next(min, max);
    }
    return array;
}

void PrintArray (int []array)
{
    Console.Write("[");
    for (int count = 0; count<array.Length; count++)
    {
        if (count<array.Length-1)
        {
        Console.Write($"{array[count]}, ");
        }
        else
        {
           Console.Write($"{array[count]}");
        }
    
    }
    Console.Write("]");
}

int CountPrimeNumbers(int[] array)
{
    int count =0;
    for (int i = 0; i<array.Length; i++) 
    {
         if(IsPrime(array[i]))
         {
            count ++;
         }
    }
    return count;
}

bool IsPrime (int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num%i==0) 
        {
            return false;
        }
    }
    return true;
}

int[] arr =CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

int countPrime = CountPrimeNumbers(arr);
Console.Write($"=> {countPrime}");