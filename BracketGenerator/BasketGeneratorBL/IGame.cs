using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public interface IGame
    {
        void SeedTeam(IGroup group, string seed, string teamName);       

        List<ITeam> GetWinners(int round, List<ITeam> teams);

        void PlayGame();
    }
}
