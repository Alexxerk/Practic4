//Написать программу копирования массива

int[]array = {12, 24, 33, 64, 75, 56, 47, 8, 59};
int count = 0;
int i = 0;
int j = 0;
for (i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
    count++;
}
void Clone(int[]arr)
{
    int[] clone = new int[count];

    for (j = 0; j < count; j++)
    {
        clone[j] = array[j];
    }
    
    j = 0;
    Console.WriteLine(" ");
    Console.Write("Данные нового массива: ");
    while(j < count)
    {
        Console.Write(clone[j] + " ");
        j++;
    }
}

Clone(array);

