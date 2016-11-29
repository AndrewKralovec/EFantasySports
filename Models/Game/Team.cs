using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Game
{
    public class Team{
        [Key]
        public int TeamID { get; set; }
        public int ManagerID { get; set; }
        public int LeagueID { get; set; }
        public string TeamName { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual League League { get; set; }
        public virtual ICollection<LeaguePlayer> Players { get; set; }

    }
}
