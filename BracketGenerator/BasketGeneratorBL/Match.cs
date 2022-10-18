using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public class Match : IMatch
    {
        public int Round { get; set; }

        public ITeam Team1 { get; set; }

        public ITeam Team2 { get; set; }
    }
}
