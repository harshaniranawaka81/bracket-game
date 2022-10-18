using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public class Game : IGame
    {
        private readonly ITournament tournament;

        public Game(ITournament tournament)
        {
            this.tournament = tournament;
        }

        public void SeedTeam(IGroup group, string seed, string teamName)
        {
            var team = new Team()
            {
                Seed = seed,
                TeamName = teamName
            };

            tournament.AddTeam(team);
            group.SeedTeam(team);

            Console.WriteLine($"Group = {group.GroupName}, Team Seed = {team.Seed}, Team Name = {team.TeamName}");
        }       

        public void PlayGame()
        {
            int round = 1;
            Console.WriteLine($"Round {round} --------------------------------------------------------------");

            var winnersPerRounds = new Dictionary<int, List<ITeam>>();

            var winners = new List<ITeam>();
            foreach (var grp in tournament.GetGroups())
            {
                var teamsPerGroup = grp.GetTeams();
                winners.AddRange(GetWinners(round, teamsPerGroup));
            }

            winnersPerRounds.Add(round, winners);

            while (winners.Count >= 2)
            {
                round++;
                Console.WriteLine();
                Console.WriteLine($"Round {round} -------------------------");

                winners = new List<ITeam>();
                winners.AddRange(GetWinners(round, winnersPerRounds[round - 1]));
                winnersPerRounds.Add(round, winners);
            }
        }

        public List<ITeam> GetWinners(int round, List<ITeam> teams)
        {
            var winners = new List<ITeam>();

            for (int i = 0; i < teams.Count; i++)
            {
                if (i + 1 < teams.Count)
                {
                    var winner = tournament.AdvanceTeam(round, teams[i].Seed, teams[i + 1].Seed);
                    winners.Add(winner);
                    i++;
                }
            }

            return winners;
        }
    }
}
