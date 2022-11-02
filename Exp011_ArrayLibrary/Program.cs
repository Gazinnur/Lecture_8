void fullArray(int[] colletion)
{
    int length = colletion.Length;
    int index = 0;
    while (index < length)
    {
        colletion[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOF(int[] colletion, int find)
{
    int count = colletion.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (colletion[index] == find)
        { 
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

fullArray(array);
PrintArray(array);

Console.WriteLine();
int pos=indexOF(array,4);
Console.WriteLine(pos);
