int[] array = { 1, 223, 3, 45, 6, 27, 84, 95, 95 };
int n = array.Length;

int find = 95;
int index = 0;
while (index < n)
{
    if (array[index] == find) {Console.WriteLine(index); break;}
    index++;
}