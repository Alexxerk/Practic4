Console.WriteLine("Введите k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
float k2 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
float b2 = float.Parse(Console.ReadLine());

void LinFunction(float one, float two, float three, float four)
{
    if (k1 == k2)
    {
        Console.WriteLine("Праммые данных функций праллельны ");
    }
    else
    {
        float x = (b2 - b1) / (k1 - k2);
        float y = k1 * x + b1;
        Console.WriteLine("Функции пересекаются при x == " + x + " и y == " + y);
    }
}

LinFunction(k1, k2, b1, b2);