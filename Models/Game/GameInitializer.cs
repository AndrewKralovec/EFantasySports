using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EFantasySports.Data; 

namespace EFantasySports.Models.Game
{
    public class GameInitializer {
        public static void Initialize(GameDbContext context) {
            context.Database.EnsureCreated(); 
            // Set up Team 
            var manager = new Manager { ManagerName= "John Smith" };
            context.Managers.Add(manager); 
            context.SaveChanges();

            var league = new League { CommissionerID = manager.ManagerID, LeagueName="Smith League" }; 
            context.Leagues.Add(league); 
            context.SaveChanges();

            var team = new Team { LeagueID = league.LeagueID, ManagerID = manager.ManagerID, TeamName = "Lions"}; 
            context.Teams.Add(team); 
            context.SaveChanges(); 

            // Set up Players 
            var players = new List<Player> {
                new Player{ LastName = "Kralovec", FirstName = "Andrew", Postion="QB" }, 
                new Player{ LastName = "Kralovec", FirstName = "Matt", Postion="QB" }, 
                new Player{ LastName = "Smith", FirstName = "John", Postion="TE" }, 
                new Player{ LastName = "Miller", FirstName = "Joe", Postion="TE" }, 
                new Player{ LastName = "Hoster", FirstName = "Blake", Postion="K" }, 
                new Player{ LastName = "Gongo", FirstName = "Frank", Postion="K" }, 
                new Player{ LastName = "Tiroski", FirstName = "Josh", Postion="DL" }, 
                new Player{ LastName = "FarFar", FirstName = "Mike", Postion="DL" }, 
                new Player{ LastName = "Banker", FirstName = "Kelly", Postion="DL" }, 
                new Player{ LastName = "York", FirstName = "Eric", Postion="DL" }, 
                new Player{ LastName = "Wacker", FirstName = "Freddy", Postion="DL" }, 
                new Player{ LastName = "Bishop", FirstName = "Mike", Postion="OL" }, 
                new Player{ LastName = "Bennet", FirstName = "Matt", Postion="OL" }, 
                new Player{ LastName = "Kowolski", FirstName = "Ben", Postion="OL" }, 
                new Player{ LastName = "Russon", FirstName = "George", Postion="OL" }, 
                new Player{ LastName = "Viker", FirstName = "Mike", Postion="OL" }, 

            };
            players.ForEach(p => context.Players.Add(p));  
            context.SaveChanges();

            var lsp = new List<LeaguePlayer> {
                new LeaguePlayer{ PlayerID =1 , TeamID=1, LeagueID=1}, 
                new LeaguePlayer{ PlayerID =3 , TeamID=1, LeagueID=1}, 
                new LeaguePlayer{ PlayerID =5 , TeamID=1, LeagueID=1}
            }; 
            lsp.ForEach(lp => context.LeaguePlayers.Add(lp)); 
            context.SaveChanges();
        }
    }
}
