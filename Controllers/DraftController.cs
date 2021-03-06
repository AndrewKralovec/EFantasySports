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
    public class DraftController : Controller {
        private readonly GameDbContext context ; 
        private readonly DateTime draftTime; 
        public DraftController(GameDbContext context){
            this.context = context; 
            this.draftTime = DateTime.Today.AddHours(22).AddMinutes(35).AddSeconds(59);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> DraftPlayer([FromBody] int playerID){
            return Json(await context.Leagues.ToListAsync());
        }
    }
}
