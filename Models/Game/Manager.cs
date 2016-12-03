using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFantasySports.Models.Game
{
    public class Manager{
        [Key]
        public int ManagerID { get; set; }
        [ForeignKey("Team")]
        public int? TeamID { get; set; }
        public string ManagerName { get; set; }
        public virtual Team Team { get; set; } 
    }
}
