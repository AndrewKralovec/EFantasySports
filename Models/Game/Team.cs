using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Game
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public int UserID { get; set; }
        public int LeagueID { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<Team> Players { get; set; }

    }
}
