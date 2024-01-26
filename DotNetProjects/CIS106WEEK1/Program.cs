using System;
using games.models;

namespace Games
{
    class Program
    {
        static void Main()
        {
            BoardGame Catan = new BoardGame("The Settlers of Catan", false, 2, 4, 90, 8);

            Console.WriteLine($"{Catan.name} can be played by {Catan.maybeMinPlayers()} to {Catan.maybeMaxPlayers()} players, takes about {Catan.avgPT} minutes to play, and rates as {Catan.difficulty} out of 10 for difficulty level.");

            Catan.expansion = true;

            Console.WriteLine($"However, if you have an expansion for it, you can play with up to {Catan.maybeMinPlayers()} or {Catan.maybeMaxPlayers()} players.");

            VideoGame Tetris = new VideoGame("Tetris", true, true, 6);

            Console.WriteLine($"{Tetris.name} can be played {Tetris.mode()} by {Tetris.players()} player(s), and rates as {Tetris.difficulty} out of 10 for difficulty.");

            Tetris.onlineOrNah = false;

            Console.WriteLine($"However, before the internet and online gaming came around, {Tetris.name} could be played {Tetris.mode()}");
        }
    }
}
