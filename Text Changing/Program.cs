//В тексте заменяем пробелы, черточками, маленькие буквы "к"
// большими "К", а большие "С" маленькими "с"

string text = "- Я думаю, - СССказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие русского короля. "
            + "ВЫ так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty'
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);

