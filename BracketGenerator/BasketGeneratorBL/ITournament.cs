using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public interface ITournament
    {
        void AddTeam(ITeam team);
        void AddGroup(IGroup group);
        List<IGroup> GetGroups();
        ITeam AdvanceTeam(int round, string teamSeed1, string teamSeed2);
        string PathToVictory();
        ITeam GetTournamentWinner();        
    }
}
