using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EFantasySports.Data; 
using EFantasySports.Models.Game; 

namespace EFantasySports.Controllers
{
    [Route("api/[controller]")]
    public class LeagueController : Controller {
        private readonly GameDbContext context ; 
        private readonly League ILeague ; 
        public LeagueController(GameDbContext context){
            this.context = context; 
            this.ILeague = new League {LeagueID =1, LeagueName ="Smith League"}; 
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetLeague(){
            var league = await context.Leagues.Include(l => l.Teams)
                .ThenInclude(m => m.Manager)
                .AsTracking()
                .SingleOrDefaultAsync(l => l.LeagueID == ILeague.LeagueID); 

            return Json(league);
        }
    }
}
