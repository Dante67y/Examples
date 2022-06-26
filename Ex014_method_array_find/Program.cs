int[] array = {16, 23, 31, 49, 16, 57, 84, 91};

int n = array.Length;
int find = 16;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1;
    index++;
}