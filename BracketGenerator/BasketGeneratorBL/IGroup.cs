using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public interface IGroup
    {
        string GroupName { get; set; }
        void SeedTeam(ITeam team);
        List<ITeam> GetTeams();
    }
}
