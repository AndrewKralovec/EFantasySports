using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFantasySports.Models.Game
{
    public class League{
        [Key]
        public int LeagueID { get; set; }
        public int CommissionerID { get; set; }
        public string LeagueName { get; set; }
        [ForeignKey("CommissionerID")]
        public virtual Manager Commisoner {get; set;} 
        public virtual ICollection<Team> Teams { get; set; }
    }
}
