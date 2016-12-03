using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EFantasySports.Data; 

namespace EFantasySports.Models.Game
{
    public class GameInitializer {
        public static void Initialize(GameDbContext context) {
            context.Database.EnsureCreated(); 

            var league = new League { LeagueName="Smith League" }; 
            context.Leagues.Add(league); 
            context.SaveChanges();

            var managers = new List<Manager> {
                new Manager { ManagerName= "John Smith" }, 
                new Manager { ManagerName= "Andrew Kralovec" }, 
                new Manager { ManagerName= "Fred Millser" }, 

            }; 
            managers.ForEach(m => context.Add(m)); 
            context.SaveChanges(); 
            var teams = new List<Team> {
                new Team { TeamName = "Lions", LeagueID=1, ManagerID = 1},
                new Team { TeamName = "Kittens", LeagueID=1, ManagerID = 2},
                new Team { TeamName = "Tigers", LeagueID=1, ManagerID = 3}
            }; 
            teams.ForEach(t => context.Add(t)); 
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
            
            var DraftedPlayers = new List<DraftedPlayer> {
                new DraftedPlayer { PlayerID = 1, LeagueID=1, TeamID = 1},
                new DraftedPlayer { PlayerID = 2, LeagueID=1, TeamID = 2},
                new DraftedPlayer { PlayerID = 3, LeagueID=1, TeamID = 3},
                new DraftedPlayer { PlayerID = 4, LeagueID=1, TeamID = 1},
                new DraftedPlayer { PlayerID = 5, LeagueID=1, TeamID = 2},
                new DraftedPlayer { PlayerID = 6, LeagueID=1, TeamID = 3}
            }; 
            DraftedPlayers.ForEach(dp => context.DraftedPlayers.Add(dp)); 
            context.SaveChanges();
        }
    }
}
