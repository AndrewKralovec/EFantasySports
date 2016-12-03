using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFantasySports.Models.Game
{
    public class Manager{
        [Key]
        public int ManagerID { get; set; }
        public string ManagerName { get; set; }
        public int? TeamID { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }
        public Manager() {}
    }
}
