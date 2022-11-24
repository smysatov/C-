// создаем метод FillArray для заполнения массива

void FillArray(int[] collection)
{
    //длина нового массива
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       //заполняем массив случайными числами
       collection[index] = new Random().Next(1, 10);
       index++;
    }
}

//создаем метод PrintArray для вывода на печать массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 42);
Console.WriteLine(pos);