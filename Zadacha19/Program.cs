Console.Clear();
int n = 5;
void FillData(int[] Data)
{
    int Lenght = Data.Length;
    int i = 0;
    Console.WriteLine("Введите пятизначное число");
    while (i < Lenght)
        {
            Data[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
}
void Palindrom(int[] x)
{
    if(x[0]==x[4] && x[1]==x[3])
    {
        Console.WriteLine("");
        Console.WriteLine("Число:" +x[0]+x[1]+x[2]+x[3]+x[4] +" является палиндромом");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Число:" +x[0]+x[1]+x[2]+x[3]+x[4] +" не является палиндромом");
    }
}
int[] Data  = new int[n];
FillData(Data);
Palindrom(Data);
