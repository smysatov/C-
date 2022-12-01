//Виды методов

// Первый Тип

void Method1()
{
    Console.WriteLine("Author...");
}

//Method1();

// Second Type

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("Message text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21(msg: "NEW TEXT", count: 5);

//Type #3

int Method3()
{
    return DateTime.Now.Year;
}

//int Year = Method3();
//Console.WriteLine(Year);

// Type 4

//string Method4(int count, string c)
//{
//    int i = 0;
//    string result = String.Empty;
//   while (i < count)
//    {
//        result = result + c;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "blblblb");
//Console.WriteLine(res);


// Цикл for
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);
