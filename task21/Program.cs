Console.WriteLine("Введите координаты первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
double lengthsegment ( double x2, double x1, double y2, double y1, double z2, double z1)
{
     return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));;
}

Console.WriteLine("Длинна отрезка - ");
Console.WriteLine (lengthsegment (x2, x1, y2, y1, z2, z1));

