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
        public virtual League League { get; set; }
    }
}
