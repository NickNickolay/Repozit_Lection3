//1. Метод, который ничего не принимает, ничего не возвращает.
void Method1()
{
    Console.WriteLine("Автор: Nick Dax!");
}

Method1();

//2. Метод, что-то принимают, ничего не возращают.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Вот и метод подъехал!");

//Разбор метода 2.

void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Выводимый текст", count: 3);
Method21(count: 3, msg: "Выводимый текс");

//3. Ничего не принимает, что-то возвращает.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4. Что-то принимают, что-то возвращают.
string Method4(int count, string Text )
{
    int i = 0;
    string result = String.Empty;
    while(i<count)
    {
        result = result + Text ;
        i++;
    }
    return result;
}
string res = Method4(3,"z ");
Console.WriteLine(res);