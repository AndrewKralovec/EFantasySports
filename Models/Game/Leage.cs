using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Game
{
    public class League
    {
        [Key]
        public int LeagueID { get; set; }
        public string LeagueName { get; set; }
        public ICollection<Roster> Rosters { get; set; }

    }
}
