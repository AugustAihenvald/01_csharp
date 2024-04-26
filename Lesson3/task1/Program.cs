int[] array = { 1, 3, 4, 19, 3 };
int num = 4;
bool isExistNum = false;

for (int i =0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;

    }
}
string result = isExistNum ? "Да": "Нет";
Console.WriteLine(result);