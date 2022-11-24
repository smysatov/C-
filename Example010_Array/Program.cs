// Нахождение индекса элемента массива со значением find

int [] array = {1,20,51,2,45,6,20,9};

int n = array.Length;
int find = 20;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}