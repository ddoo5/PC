using PC_code;

List<char> _lowlet = new List<char>();
_lowlet.AddRange("abcdefghijklmnopqrstuvwxyz");

List<char> _caplet = new List<char>();
_caplet.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

List<char> _sign = new List<char>();
_sign.AddRange("-'^*~@/!#$%&");

List<char> _numbers = new List<char>();
_numbers.AddRange("1234567890");

Random rnd = new();
int x;


Hentai.Picture(); //вывод картинки
Console.WriteLine("\n \n");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Если пароль похож на следующий: Kxxxxxw ,то лучше его заменить");
Console.ResetColor();
Console.WriteLine("\n \n");

while (true)   //основной метод
{
    try
    {
        Console.WriteLine("Выберите нужный вид пароля, введя предложенную из цифр:\n" +
        "1) обычный пароль(6 символов)\n" +
        "2) пароль с использованием цифр(8 символов)\n" +
        "3) пароль с использованием символов(8 символов)\n" +
        "4) сложный пароль(16 символов)\n" +
        "5) случайный пароль(до 30 символов)");

        int typen = Convert.ToInt32(Console.ReadLine());
        string password;

        switch (typen)
        {
            case 1:
                password = Creator(1, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n " + password + "\n");
                Console.ResetColor();
                break;
            case 2:
                password = Creator(2, 8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n " + password + "\n");
                Console.ResetColor();
                break;
            case 3:
                password = Creator(3, 8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n " + password + "\n");
                Console.ResetColor();
                break;
            case 4:
                password = Creator(4, 16);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n " + password + "\n");
                Console.ResetColor();
                break;
            case 5:
                password = Creator(5, 0);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n " + password + "\n");
                Console.ResetColor();
                break;
            default:
                throw new Exception("Enter exsiting number");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Exception: {ex.Message}");
        Console.ResetColor();
    }
}


string Creator(int n, int y)  //Метод, который создает пароль, в зависимости от нужного типа
{
    string password = "";
    int _randomLenght = rnd.Next(6, 30);

    if (n == 1)
    {
        for (int i = 0; i < y; i++)
        {
            char f = Randomizer(1);
            password += f;
        }
    }
    else if (n == 2)
    {
        for (int i = 0; i < y; i++)
        {
            char f = Randomizer(2);
            password += f;
        }
    }
    else if (n == 3)
    {
        for (int i = 0; i < y; i++)
        {
            char f = Randomizer(4);
            password += f;
        }
    }
    else if (n == 4)
    {
        for (int i = 0; i < y; i++)
        {
            char f = Randomizer(3);
            password += f;
        }
    }
    else if (n == 5)
    {
        for (int i = 0; i < _randomLenght; i++)
        {
            char f = Randomizer(3);
            password += f;
        }
    }
    return password;
}


char RandomLowlet() // Метод для выбора рандомной строчной буквы
{
    x = rnd.Next(0, _lowlet.Count);
    char c = _lowlet[x];

    return c;
}


char RandomCaplet()  // Метод для выбора рандомной прописной буквы
{
    x = rnd.Next(0, _caplet.Count);
    char c = _caplet[x];

    return c;
}


char RandomSign()  //Метод для выбора рандомного знака
{
    x = rnd.Next(0, _sign.Count);
    char c = _sign[x];

    return c;
}


char RandomNumber()  //Метод для выбора рандомной цифры
{
    x = rnd.Next(0, _numbers.Count);
    char c = _numbers[x];

    return c;
}


char Randomizer(int q)  //Метод, который рандомно выбирает тип символа для пароля
{
    char letter = 'x';
    int r = rnd.Next(0, q + 1 );

    if(q == 4)
    {
        r = rnd.Next(0, q - 1);
        switch (r)
        {
            case 0:
                letter = RandomLowlet();
                break;
            case 1:
                letter = RandomCaplet();
                break;
            case 2:
                letter = RandomSign();
                break;
        }
    }
    else
    {
        switch (r)
        {
            case 0:
                letter = RandomLowlet();
                break;
            case 1:
                letter = RandomCaplet();
                break;
            case 2:
                letter = RandomNumber();
                break;
            case 3:
                letter = RandomSign();
                break;
        }
    }
    return letter;
}
