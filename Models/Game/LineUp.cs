using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class LineUp{
        [Key]
        public int LineUpID { get; set; }
        public int TeamID { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public LineUp() {
            Players = new List<Player>();
        }
    }
}