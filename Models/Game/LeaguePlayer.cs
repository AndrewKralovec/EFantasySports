using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; 

namespace EFantasySports.Models.Game
{
    public class LeaguePlayer{
        [Key]
        public int LeaguePlayerID { get; set; }
        public int TeamID { get; set; }
        public int LeagueID { get; set; }
        public virtual Team Team { get; set; }
        public virtual League League { get; set; }

    }
}
