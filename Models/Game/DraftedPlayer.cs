using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class DraftedPlayer {
        [Key]
        public int DraftedPlayerID { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public int LeagueID { get; set; }
        [ForeignKey("PlayerID")]
        public virtual Player Player { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }
        [ForeignKey("LeagueID")]
        public virtual League League { get; set; }
        public DraftedPlayer() {}
    }
}
