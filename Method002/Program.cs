/*Цикл for
string Method1(int count, string Text )
{
    string result = String.Empty;
    for(int i=0; i<count; i++)
    {
        result = result + Text ;
    }
    return result;
}
string res = Method1(3,"z ");
Console.WriteLine(res);

//Цикл в цикле (таблица умножения).

for(int i = 2; i<= 10; i++ )
{
    for(int j = 2; j<=10; j++)
    {
    Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
*/
//=======Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, " 
            + "ежели бы вас послали вместо нашего милого Винцегнероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "text"
//            012
//s[2] = x 
string Replace(string text, char oldValue, char newValue)
{
string result = String.Empty;
int lenght = text.Length;

for(int i=0;i<lenght;i++)
{
    if(text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
}
    return result;
}
string Newtext = Replace(text, ' ', '|');
Console.WriteLine(Newtext);

Console.WriteLine();
Newtext = Replace(text, 'к', 'К');
Console.WriteLine(Newtext);

Console.WriteLine();
Newtext = Replace(text, 'C', 'c');
Console.WriteLine(Newtext);
//Добавили дефект речи (глумлюсь).
Console.WriteLine();
Newtext = Replace(text, 'р', 'л');
Console.WriteLine(Newtext);