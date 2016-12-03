using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class Team{
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int ManagerID { get; set; }
        public int LeagueID { get; set; }
        [ForeignKey("LeagueID")]
        public virtual League League { get; set; }
        [ForeignKey("ManagerID")]
        public virtual Manager Manager { get; set; }
        public virtual ICollection<DraftedPlayer> Players { get; set; }

        public Team() {
            Players = new List<DraftedPlayer>();
        }
    }
}
