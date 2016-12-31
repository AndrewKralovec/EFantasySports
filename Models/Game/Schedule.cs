using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class Schedule {
        [Key]
        public int ScheduleID { get; set; }
        public int LeagueID { get; set; }
        public int? HomeID { get; set; }
        // Specify 'ON DELETE NO ACTION' later 
        public int? AwayID { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("LeagueID")]
        public virtual League League { get; set; }
        [ForeignKey("HomeID")]
        public virtual Team Home { get; set; }
        [ForeignKey("AwayID")]
        public virtual Team Away { get; set; }
        public Schedule() {}
    }
}
