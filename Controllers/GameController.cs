using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EFantasySports.Data; 

namespace EFantasySports.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller {
        private readonly GameDbContext context ; 
        public GameController(GameDbContext context){
            this.context = context; 
        }
        public async Task<IActionResult> getPlayers(){
            return Json(await context.Players.ToListAsync()); 
        }
        public async Task<IActionResult> getTeams(){
            return Json(await context.Leagues.ToListAsync());
        }
    }
}
