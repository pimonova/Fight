using System;

public enum Fight
{
    Head,
    Body,
    Legs,
}

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playerFight, playerProtection, computerFight, computerProtection;
            int[] playerScore = new int[1];
            int[] computerScore = new int[1];
            int ip = 0;
            int ic = 0;

            do
            {

                Console.WriteLine("Выберите, куда бить:");
                Console.WriteLine($"Удар в голову {(int)Fight.Head}.");
                Console.WriteLine($"Удар в тело {(int)Fight.Body}.");
                Console.WriteLine($"Удар в ноги {(int)Fight.Legs}.");

                playerFight = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите, что защитить:");
                Console.WriteLine($"Голову {(int)Fight.Head}.");
                Console.WriteLine($"Тело {(int)Fight.Body}.");
                Console.WriteLine($"Ноги {(int)Fight.Legs}.");

                playerProtection = int.Parse(Console.ReadLine());

                Console.Clear();

                computerFight = rnd.Next(0, 2);
                computerProtection = rnd.Next(0, 2);

                if (playerFight != computerProtection)
                {
                    playerScore[ip] = 1;
                    ip++;
                    Array.Resize(ref playerScore, playerScore.Length + 1);
                    Console.WriteLine("Игрок попал!");
                }
                else
                {
                    Console.WriteLine("Игрок не попал!");
                }

                if (computerFight != playerProtection)
                {
                    computerScore[ic] = 1;
                    ic++;
                    Array.Resize(ref computerScore, computerScore.Length + 1);
                    Console.WriteLine("Компьютер попал!");
                }
                else
                {
                    Console.WriteLine("Компьютер не попал!");
                }

                Console.WriteLine("\n");
            } while (!(playerScore.Length == 6 && computerScore.Length < 6) || !(playerScore.Length < 6 && computerScore.Length == 6) || !(playerScore.Length >= 6 && computerScore.Length >= 6 && Math.Abs(computerScore.Length - playerScore.Length) != 2));

            if (playerScore.Length==6)
            {
                Console.WriteLine("Игрок победил!");
            }
            else
            {
                Console.WriteLine("Компьютер победил!");
            }

        }
    }
}