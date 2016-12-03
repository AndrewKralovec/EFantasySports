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
        public TeamController(GameDbContext context){
            this.context = context; 
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> getTeam(){
            var x = await context.Teams
                .Include(t => t.League)
                .Include(t => t.Players)
                .ThenInclude(p => p.Player)
                .ToListAsync(); 
            return Json(x);
        }
    }
}
