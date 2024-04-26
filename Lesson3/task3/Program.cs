int[] array = { 1, 3, 2, 4, 2, 3 };
int[] array2 = new int[array.Length / 2];

int left = 0;
int right = array.Length - 1;

while (left < right)
{
    array2[left] = array[left] * array[right];
    left++;
    right--;
}

for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i] + " ");
}