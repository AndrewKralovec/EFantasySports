using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; 

namespace EFantasySports.Models.Game
{
    public class Player {
        [Key]
        public int PlayerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Postion { get; set; }
    }
}
