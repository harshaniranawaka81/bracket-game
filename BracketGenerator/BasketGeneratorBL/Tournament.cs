using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public class Tournament : ITournament
    {
        private readonly List<IGroup> groups;
        private readonly List<ITeam> teams;
        private readonly LinkedList<IMatch> winningOrder;
        private readonly LinkedList<ITeam> winners;

        //Singleton for the tournament 
        private static Tournament tournament = null;
        public static Tournament GetInstance
        {
            get
            {
                if (tournament == null)
                    tournament = new Tournament();
                return tournament;
            }
        }

        public Tournament()
        {
            groups = new List<IGroup>();
            teams = new List<ITeam>();           
            winningOrder = new LinkedList<IMatch>();
            winners = new LinkedList<ITeam>();
        }

        public void AddTeam(ITeam team)
        {
            teams.Add(team);
        }

        public void AddGroup(IGroup group)
        {
            groups.Add(group);
        }

        public List<IGroup> GetGroups()
        {
            return groups;
        }

        public ITeam AdvanceTeam(int round, string teamSeed1, string teamSeed2)
        {
            var team1 = teams.Find(t => t.Seed == teamSeed1);

            if (team1 == null)
            {
                Console.WriteLine($"Invalid team seed: {teamSeed1} passed to AdvanceTeam method");
                return null;
            }

            var team2 = teams.Find(t => t.Seed == teamSeed2);

            if (team2 == null)
            {
                Console.WriteLine($"Invalid team seed: {teamSeed2} passed to AdvanceTeam method");
                return null;
            }

            var match = new Match()
            {
                Round = round,
                Team1 = team1,
                Team2 = team2
            };

            winningOrder.AddLast(match);

            Console.WriteLine($"Team1 = {team1.TeamName}, Team2 = {team2.TeamName}");

            //Select the winning team randomly
            Random rnd = new();
            int winningTeamNo = rnd.Next(1, 2);

            var winningTeam = winningTeamNo == 1 ? team1 : team2;

            winners.AddLast(winningTeam);

            Console.WriteLine($"Winner = {winningTeam.TeamName}");

            return winningTeam;
        }

        public string PathToVictory()
        {
            var winningPathString = new StringBuilder();
            foreach (var match in winningOrder)
            {
                winningPathString.Append($"-> {match.Team1.TeamName} vs {match.Team2.TeamName} \n");
            }

            winningPathString.Append($"-> {GetTournamentWinner().TeamName}");

            return winningPathString.ToString();
        }

        public ITeam GetTournamentWinner()
        {
            var winner = winners.Last;
            return winner.Value;
        }
    }
}
