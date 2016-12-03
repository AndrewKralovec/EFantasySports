using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class Team{
        [Key]
        public int TeamID { get; set; }
        [ForeignKey("Manager")]
        public int ManagerID { get; set; }
        [ForeignKey("League")]
        public int LeagueID { get; set; }
        public string TeamName { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual League League { get; set; }
        public virtual ICollection<LeaguePlayer> Players { get; set; }

    }
}
