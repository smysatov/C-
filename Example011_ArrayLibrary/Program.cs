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

int[] array = new int[10];

FillArray(array);
PrintArray(array);