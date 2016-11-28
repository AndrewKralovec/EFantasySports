using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFantasySports.Models.Account
{
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public int AccessFailedCount{get; set;}
        public string ConcurrencyStamp{get; set;}
            //.IsConcurrencyToken();
        public string Email{get; set;}
            // .HasAnnotation("MaxLength", 256);
        public bool EmailConfirmed{get; set;}
        public bool LockoutEnabled{get; set;}
        public DateTimeOffset? LockoutEnd{get; set;}
        public string NormalizedEmail{get; set;}
            // .HasAnnotation("MaxLength", 256);
        public string NormalizedUserName{get; set;}
            //.HasAnnotation("MaxLength", 256);
        public string PasswordHash{get; set;}
        public string PhoneNumber{get; set;}
        public bool PhoneNumberConfirmed{get; set;}
        public string SecurityStamp{get; set;}
        public bool TwoFactorEnabled{get; set;}
        public string UserName{get; set;}
            //.HasAnnotation("MaxLength", 256);
    }
}
