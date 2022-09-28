using System;
using System.Drawing;

void Task1()
{
    Console.WriteLine("Введите число для проверки на палиндром:");
    int a = int.Parse(Console.ReadLine());
    int b = a;
    var col = new List<int>();
    while (b > 0)
    {
        col.Add(b % 10);
        b = b / 10;
    }
    b = 0;
    col.Reverse();
    for (int mcol = 0; mcol < col.Count; mcol++)
        b = b + col[mcol] * (int)Math.Pow(10, mcol);
    if (a == b)
        Console.WriteLine("Палиндром");
    else
        Console.WriteLine("Не палиндром");
}

void Task2()
{
    int x1 = Coordinate("x", "A");
    int y1 = Coordinate("y", "A");
    int z1 = Coordinate("z", "A");
    int x2 = Coordinate("x", "B");
    int y2 = Coordinate("y", "B");
    int z2 = Coordinate("z", "B");

    int Coordinate(string coorName, string pointName)
    {
        Console.Write($"Введите координату {coorName} точки {pointName}: ");
        return Convert.ToInt16(Console.ReadLine());
    }

    double Decision(double x1, double x2,
                    double y1, double y2,
                    double z1, double z2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                         Math.Pow((y2 - y1), 2) +
                         Math.Pow((z2 - z1), 2));
    }

    double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

    Console.WriteLine($"Длина отрезка  {segmentLength}");
}

void Task3()
{
    Console.Write("Введите число: ");
    int cube = Convert.ToInt32(Console.ReadLine());

    void Cube(int[] cube)
    {
        int counter = 0;
        int length = cube.Length;
        while (counter < length)
        {
            cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
            counter++;
        }
    }

    void PrintArry(int[] coll)
    {
        int count = coll.Length;
        int index = 0;
        while (index < count)
        {
            Console.Write(coll[index] + " ");
            index++;
        }
    }

    int[] arry = new int[cube + 1];
    Cube(arry);
    PrintArry(arry);
}

while (true)
{
    Console.WriteLine("Введите номер задачи");
    int a = int.Parse(Console.ReadLine());
    if (a == 1)
    {
        Task1();
    }
    if (a == 2)
    {
        Task2();
    }
    if (a == 3)
    {
        Task3();
    }
}