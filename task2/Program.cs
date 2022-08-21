//Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)


Console.WriteLine("Введите количество вершин: ");
int n = int.Parse(Console.ReadLine());
double[] arrayX = new double[n];
double[] arrayY = new double[n];

int ver = 1;
double k = 0;
int i = 0;
double b = 0;

for (i = 0; i < n; i++)
{
    Console.WriteLine("Введите значение вершинны x" + ver + ":");
    arrayX[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение вершинны y" + ver + ":");
    arrayY[i] = double.Parse(Console.ReadLine());

    
    ver++;
}

k = (arrayY[n - 1] - arrayY[0]) / (arrayX[n - 1] - arrayX[0]);
b = arrayY[n - 2] - (k * arrayX[n - 2]);
Console.WriteLine("k == " + k + " b == " + b + " линейной функции ограниченной двумя вершинами " + arrayX[n - 2] + " " + arrayY[n - 2] + "," + arrayX[n - 1] + " " + arrayY[n - 1]);

for (i = 0; i < n; i++)
{
    k = (arrayY[i] - arrayY[i + 1]) / (arrayX[i] - arrayX[i + 1]);
    b = arrayY[i] - (k * arrayX[i]);
    Console.WriteLine("k == " + k + " b == " + b + " линейной функции ограниченной двумя вершинами " + arrayX[i] + " " + arrayY[i] + "," + arrayX[i + 1] + " " + arrayY[i + 1]); 
}


















