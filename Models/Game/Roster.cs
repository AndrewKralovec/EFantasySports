using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Game
{
    public class Roster
    {
        [Key]
        public int RosterID { get; set; }
        public int LeagueID { get; set; }
        public int TeamID { get; set; } 
        public League League { get; set; }
        public Team Team { get; set; }
    }
}
