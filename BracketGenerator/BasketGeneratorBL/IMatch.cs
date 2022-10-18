using System;
using System.Collections.Generic;
using System.Text;

namespace BasketGeneratorBLL
{
    public interface IMatch
    {
        int Round { get; set; }
        ITeam Team1 { get; set; }
        ITeam Team2 { get; set; }
    }
}
