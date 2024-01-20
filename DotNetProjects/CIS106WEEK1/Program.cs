using System;
using games.models;

namespace Games
{
    class Program
    {
        static void Main()
        {
            BoardGame Catan = new BoardGame("The Settlers of Catan", false, 2, 4, 90, 8);

            Console.WriteLine($"{Catan.Name} can be played by {Catan.MaybeMinPlayers()} to {Catan.MaybeMaxPlayers()} players, takes about {Catan.AvgPT} minutes to play, and rates as {Catan.Difficulty} out of 10 for difficulty level.");

            Catan.Expansion = true;

            Console.WriteLine($"However, if you have an expansion for it, you can play with up to {Catan.MaybeMinPlayers()} or {Catan.MaybeMaxPlayers()} players.");

            VideoGame Tetris = new VideoGame("Tetris", true, true, 6);

            Console.WriteLine($"{Tetris.Name} can be played {Tetris.Mode()} by {Tetris.Players()} player(s), and rates as {Tetris.Difficulty} out of 10 for difficulty.");

            Tetris.OnlineOrNah = false;

            Console.WriteLine($"However, before the internet and online gaming came around, {Tetris.Name} could be played {Tetris.Mode()}");
        }
    }
}
