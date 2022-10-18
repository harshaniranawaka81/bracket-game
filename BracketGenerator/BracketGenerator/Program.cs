using BasketGeneratorBLL;
using BasketGeneratorDAL;
using System;

namespace BracketGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tournament = Tournament.GetInstance;

            var game = new Game(tournament);

            var gameData = new GameData(tournament, game);
            gameData.SeedAllTeams(tournament);

            Console.WriteLine();
            
            game.PlayGame();

            Console.WriteLine();

            Console.WriteLine($"Winner: {tournament.GetTournamentWinner().TeamName}");

            Console.WriteLine();

            Console.WriteLine($"WinningOrder: {tournament.PathToVictory()}");
        }
      
    }
}
