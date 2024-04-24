

int n =10;
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 0;

while(i<n)
{
    if (arr[i]%2 == 0)
    {
        Console.Write($"{arr[i]} ");
    } 
    i = i+1;
}

