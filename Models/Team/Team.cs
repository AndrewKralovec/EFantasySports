using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Account
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public int UserID { get; set; }
        public string TeamName { get; set; }
    }
}
