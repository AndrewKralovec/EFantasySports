using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Game
{
    public class Manager{
        [Key]
        public int ManagerID { get; set; }
        public int? TeamID { get; set; }
        public string ManagerName { get; set; }
        public virtual Team Team { get; set; } 
    }
}
