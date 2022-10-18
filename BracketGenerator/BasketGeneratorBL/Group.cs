using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public class Group : IGroup
    {
        private readonly List<ITeam> teams;

        public string GroupName { get; set; }

        public Group()
        {
            teams = new List<ITeam>();
        }

        public void SeedTeam(ITeam team)
        {
            teams.Add(team);
        }

        public List<ITeam> GetTeams()
        {
            return teams;
        }
    }
}
