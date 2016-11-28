using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFantasySports.Models.Account
{
    public class League
    {
        [Key]
        public int LeagueID { get; set; }
        public string LeagueName { get; set; }
    }
}
