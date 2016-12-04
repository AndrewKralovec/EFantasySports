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
    public class TeamController : Controller {
        private readonly GameDbContext context ; 
        private readonly Manager manager ; 
        public TeamController(GameDbContext context){
            this.context = context; 
            this.manager = new Manager {ManagerID=1, ManagerName="Andrew Kralovec", TeamID=1}; 
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetTeam(){
            var x = await context.Teams
                .Include(t => t.League)
                .Include(t => t.Manager)
                .Include(t => t.Players)
                .ThenInclude(p => p.Player)
                .AsNoTracking()
                .SingleOrDefaultAsync(t => t.ManagerID == this.manager.ManagerID); 
            return Json(x);
        }
    }
}
