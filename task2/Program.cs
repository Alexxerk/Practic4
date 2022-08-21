//Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)


Console.WriteLine("Введите количество вершин: ");
int n = int.Parse(Console.ReadLine());
double[] arrayX = new double[n];
double[] arrayY = new double[n];
int ver = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите значение вершинны x" + ver + ":");
    arrayX[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение вершинны y" + ver + ":");
    arrayY[i] = double.Parse(Console.ReadLine());

    ver++;
}

void Mastab(double[] array1, double[] array2)
{
Console.WriteLine("Введите K: ");
double k = double.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
     Console.Write("(" + arrayX[i] + ", " + arrayY[i] + ") " );
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    double x = arrayX[i] * k;   
    double y = arrayY[i] * k;
    Console.Write("(" + x + ", " + y + ") " );
}
}

Mastab(arrayX, arrayY);
















