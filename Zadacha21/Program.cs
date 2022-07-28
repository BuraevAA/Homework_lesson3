Console.Clear();
Console.WriteLine("Введите первую координату х1 первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату y1 первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третью координату z1 первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату х2 второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату y2 второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третью координату z2 второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double num1 = Math.Pow(x2-x1,2);
    double num2 = Math.Pow(y2-y1,2);
    double num3 = Math.Pow(z2-z1,2);
    double summ = num1 + num2 + num3;
    return Math.Sqrt(summ);
}
Console.WriteLine("Расстояние между двумя точками в пространстве: " +distance(x1, x2, y1, y2, z1, z2));
