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
            this.manager = new Manager { ManagerID =1 ,TeamID =1 , ManagerName= "John Smith" }; 
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> getTeam(){
            var x = await context.Teams.ToListAsync();  

            var y = await context.Teams.Include(s => s.Players)
                .SingleOrDefaultAsync(t => t.ManagerID == manager.ManagerID);

            var z = await context.Leagues.Include(l => l.Teams)
                .ThenInclude(t => t.Players)
                .AsNoTracking()
                .ToListAsync(); 

            return Json(y);
        }
    }
}
