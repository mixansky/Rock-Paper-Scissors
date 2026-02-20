using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wins = 0, draws = 0, loses = 0;
            Random rand = new Random();
            string[] moves = { "Камень", "Ножницы", "Бумага" };

            while (true)
            {
                Console.WriteLine("\n1. Играть, 2. Статистика, 3. Остановить");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Твой ход (камень/ножницы/бумага): ");
                    string player = Console.ReadLine().ToLower().Trim();
                    string comp = moves[rand.Next(3)].ToLower();
                    Console.WriteLine($"Твой ход: {player} vs {comp}");

                    if (player != "камень" && player != "ножницы" && player != "бумага")
                    {
                        Console.WriteLine("Неверный ход! Только: камень/ножницы/бумага");
                    }
                    else
                    {
                        if (player == "ножницы" && comp == "бумага") { Console.WriteLine("Ты победил!"); wins++; }
                        else if (player == "бумага" && comp == "ножницы") { Console.WriteLine("Ты проиграл!"); loses++; }
                        else if (player == "камень" && comp == "ножницы") { Console.WriteLine("Ты победил!"); wins++; }
                        else if (player == "ножницы" && comp == "камень") { Console.WriteLine("Ты проиграл!"); loses++; }
                        else if (player == "бумага" && comp == "камень") { Console.WriteLine("Ты победил!"); wins++; }
                        else if (player == "камень" && comp == "бумага") { Console.WriteLine("Ты проиграл!"); loses++; }
                        else if (player == comp) { Console.WriteLine("Ничья!"); draws++; }
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine($"Результаты: Побед: {wins}, Проигрышей: {loses}, Ничьих: {draws}");
                }
                else if (choice == "3")
                {
                    break;
                }
            }
        }
    }
}
