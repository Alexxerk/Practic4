//Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)


Console.WriteLine("Введите количество вершин: ");
int n = int.Parse(Console.ReadLine());
int[] arrayX = new int[n];
int[] arrayY = new int[n];

int ver = 1;
int k = 0;
int i = 0;
int maxX = 0;
int minX = 0;
int maxY = 0;
int minY = 0;
int x = 0;
int y = 0;
int b = 0;

//задаем вершины

for (i = 0; i < n; i++)
{
    Console.WriteLine("Введите вершину " + ver);
    Console.WriteLine("Введите значение вершинны x" + ver + ":");
    arrayX[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение вершинны y" + ver + ":");
    arrayY[i] = int.Parse(Console.ReadLine());

    
    ver++;
}

//находим k и b
for (i = 0; i < n; i++)
{
    k = (arrayY[i] - arrayY[i + 1]) / (arrayX[i] - arrayX[i + 1]);
    b = arrayY[i] - (k * arrayX[i]);

    if (arrayX[i] > arrayX[i+1])
    {
        maxX = arrayX[i];
    }
    else
    {
        maxX = arrayX[i+1];
    }

    if (arrayY[i] > arrayY[i+1])
    {
        maxY = arrayY[i];
    }
    else
    {
        maxY = arrayY[i+1];
    }

    if (maxX > maxY)
    {
        Console.SetCursorPosition(minX, minY);
        Console.WriteLine("*");

        while(minX <= maxX)
        {
            x = arrayX[i] + 1;
            y = k * x + b;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
            minX++;
        }

}
    else
    {
        Console.SetCursorPosition(minX, minY);
        Console.WriteLine("*");

        while(minY <= maxY)
        {
            y = arrayY[i] + 1;
            x = (y - b) / k;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
            minY++;
        }

    }
}














