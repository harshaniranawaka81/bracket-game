using System;
using BasketGeneratorBLL;

namespace BasketGeneratorDAL
{
    public class GameData
    {
        private readonly ITournament tournament;
        private readonly IGame game;

        public GameData(ITournament tournament, IGame game)
        {
            this.tournament = tournament;
            this.game = game;
        }

        public void SeedAllTeams(ITournament tournament)
        {
            var groupA = new Group()
            {
                GroupName = "A"
            };
            game.SeedTeam(groupA, "1A", "Qatar");
            game.SeedTeam(groupA, "2A", "Ecuador");
            game.SeedTeam(groupA, "3A", "Senegal");
            game.SeedTeam(groupA, "4A", "Natherlands");

            tournament.AddGroup(groupA);

            var groupB = new Group()
            {
                GroupName = "B"
            };
            game.SeedTeam(groupB, "1B", "England");
            game.SeedTeam(groupB, "2B", "Iran");
            game.SeedTeam(groupB, "3B", "United States");
            game.SeedTeam(groupB, "4B", "UKR/SCO/WAL");

            tournament.AddGroup(groupB);

            var groupC = new Group()
            {
                GroupName = "C"
            };
            game.SeedTeam(groupC, "1C", "Argentina");
            game.SeedTeam(groupC, "2C", "Saudi Arabia");
            game.SeedTeam(groupC, "3C", "Mexico");
            game.SeedTeam(groupC, "4C", "Poland");

            tournament.AddGroup(groupC);

            var groupD = new Group()
            {
                GroupName = "D"
            };
            game.SeedTeam(groupD, "1D", "France");
            game.SeedTeam(groupD, "2D", "AUS/ERE/PER");
            game.SeedTeam(groupD, "3D", "Denmark");
            game.SeedTeam(groupD, "4D", "Tunisia");

            tournament.AddGroup(groupD);


            var groupE = new Group()
            {
                GroupName = "E"
            };
            game.SeedTeam(groupE, "1E", "Spain");
            game.SeedTeam(groupE, "2E", "CRC/NZL");
            game.SeedTeam(groupE, "3E", "Germany");
            game.SeedTeam(groupE, "4E", "Japan");

            tournament.AddGroup(groupE);

            var groupF = new Group()
            {
                GroupName = "F"
            };
            game.SeedTeam(groupF, "1F", "Belgium");
            game.SeedTeam(groupF, "2F", "Canada");
            game.SeedTeam(groupF, "3F", "Morocco");
            game.SeedTeam(groupF, "4F", "Croatia");

            tournament.AddGroup(groupF);

            var groupG = new Group()
            {
                GroupName = "G"
            };
            game.SeedTeam(groupG, "1G", "Brazil");
            game.SeedTeam(groupG, "2G", "Serbia");
            game.SeedTeam(groupG, "3G", "Switzerland");
            game.SeedTeam(groupG, "4G", "Cameroon");

            tournament.AddGroup(groupG);

            var groupH = new Group()
            {
                GroupName = "H"
            };
            game.SeedTeam(groupH, "1H", "Portugal");
            game.SeedTeam(groupH, "2H", "Gahana");
            game.SeedTeam(groupH, "3H", "Uruguay");
            game.SeedTeam(groupH, "4H", "South Korea");

            tournament.AddGroup(groupH);
        }
     
    }
}
