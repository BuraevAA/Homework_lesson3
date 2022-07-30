Console.Clear();
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
void ryad (int count)
{
    count = 1;
    while(count<=N)
    {
        Console.Write(Math.Pow(count,3) +"  ");
        count++;
    }
}
ryad(N);