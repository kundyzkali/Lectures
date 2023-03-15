﻿string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
              + "ежели бы вас послали вместо нашего милого Винценгероде,"
              + "вы бы взяли приступом согласие прусского короля. "
              + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldvalue, char newvalue)
{
    string result = string.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldvalue) result = result + $"{newvalue}";
        else result = result + $"{text[i]}";
        }


    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();