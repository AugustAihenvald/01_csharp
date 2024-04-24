int n = 5;
int[] array = {1,2,3,6,8};
int max = array[0];

max = array[0];
for (int j = 0; j<n; j++)
{
    if (array[j]>max)
    {
        max = array[j];
    }
    
}
Console.WriteLine(max);
 
max = array[0];
foreach (int e in array)
{
    if (e>max)
    {
        max = e;
    }
    
}
Console.WriteLine(max);