using System.Collections.Generic;
using PC_code;

Hentai.Picture();

List<char> _lowlet = new List<char>();
_lowlet.AddRange("abcdefghijklmnopqrstuvwxyz");

List<char> _caplet = new List<char>();
_caplet.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

List<char> _sign = new List<char>();
_sign.AddRange("-'^*~@/!#$%&");

List<char> _numbers = new List<char>();
_numbers.AddRange("1234567890");

Random rnd = new Random();
int x;

char lowlet()
{
    x = rnd.Next(0, _lowlet.Count);
    char c = _lowlet[x];
    return c;
}

char caplet()
{
    x = rnd.Next(0, _caplet.Count);
    char c = _caplet[x];
    return c;
}

char signs()
{
    x = rnd.Next(0, _sign.Count);
    char c = _sign[x];
    return c;
}

char numbers()
{
    x = rnd.Next(0, _numbers.Count);
    char c = _numbers[x];
    return c;
}

char swt(int q)
{
    char letter = 'o';
    int r = rnd.Next(q + 1);
    switch (r)
    {
        case 0:
            return letter = lowlet();
            break;
        case 1:
            return letter = caplet();
            break;
        case 2:
            return letter = numbers();
            break;
        case 3:
            return letter = signs();
            break;
    }
    return letter;
}

string _rnd(int n, int y)
{
    string word = "";
    if (n == 1)
    {
        for (int i = 0; i < y; i++)
        {
            char f = swt(1);
            word += f;
        }
    }
    else if (n == 2)
    {
        for (int i = 0; i < y; i++)
        {
            char f = swt(2);
            word += f;
        }
    }
    else
    {
        for (int i = 0; i < y; i++)
        {
            char f = swt(3);
            word += f;
        }
    }
    return word;
}

Console.WriteLine("Выберите нужный вид пароля, написав цифру\n1) обычный пароль(6 символов)\n" +
    "2) пароль с использованием цифр(8 символов)\n" +
    "3) пароль с использованием спец.символов(8 символов)\n4) сложный пароль(16 символов)");

try
{
    int typen = Convert.ToInt32(Console.ReadLine());
    string password;
    switch (typen)
    {
        case 1:
            password = _rnd(1, 6);
            Console.WriteLine(password);
            break;
        case 2:
            password = _rnd(2, 8);
            Console.WriteLine(password);
            break;
        case 3:
            password = _rnd(3, 8);
            Console.WriteLine(password);
            break;
        case 4:
            password = _rnd(3, 16);
            Console.WriteLine(password);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите нужную цифру");
            break;


    }
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введите нужную цифру");
}