internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите за какое количесво раундов определится победитель");
        int N = Convert.ToInt32(Console.ReadLine());
        int points_player = 0;
        int points_com = 0;
        int i = 0;
        while (i < N)
        {
            Console.WriteLine("Введите камень, ножницы или бумага");
            string sign_player = Console.ReadLine();
            string[] sign_com = { "камень", "ножницы", "бумага" };
            string sign_c = sign_com[new Random().Next(0, sign_com.Length)];
            Console.WriteLine("Выбор компьютера: " +sign_c);
            if (sign_player.ToLower() == "камень" && sign_c == "камень")
            {
                points_player = points_player + 1;
                points_com = points_com + 1;
                i++;
            }
            else if (sign_player.ToLower() == "камень" && sign_c == "ножницы")
            {
                points_player = points_player + 2;
                i++;
            }
            else if (sign_player.ToLower() == "камень" && sign_c == "бумага")
            {
                points_com = points_com + 2;
                i++;
            }
            else if (sign_player.ToLower() == "ножницы" && sign_c == "камень")
            {
                points_com = points_com + 2;
                i++;
            }
            else if (sign_player.ToLower() == "ножницы" && sign_c == "ножницы")
            {
                points_player = points_player + 1;
                points_com = points_com + 1;
                i++;
            }
            else if (sign_player.ToLower() == "ножницы" && sign_c == "бумага")
            {
                points_player = points_player + 2;
                i++;
            }
            else if (sign_player.ToLower() == "бумага" && sign_c == "камень")
            {
                points_player = points_player + 2;
                i++;
            }
            else if (sign_player.ToLower() == "бумага" && sign_c == "ножницы")
            {
                points_com = points_com + 2;
                i++;
            }
            else if (sign_player.ToLower() == "бумага" && sign_c == "бумага")
            {
                points_player = points_player + 1;
                points_com = points_com + 1;
                i++;
            }
            else Console.WriteLine("Введены некоректные данные");
            Console.WriteLine("Количество очков игрока: " +points_player);
            Console.WriteLine("Количество очков компьютера: " +points_com);
        }
        if (points_player > points_com) Console.WriteLine("Победил Игрок");
        else Console.WriteLine("Победил компьютер");
    }
}