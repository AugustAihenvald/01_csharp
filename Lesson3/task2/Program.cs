
int[] array = { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
