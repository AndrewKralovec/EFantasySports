using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; 
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class LeaguePlayer{
        // Convert to composite key later [colm = (1,2,3 )] 
        public int LeaguePlayerID { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public int LeagueID { get; set; }
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
        public virtual League League { get; set; }

    }
}
