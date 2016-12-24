using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EFantasySports.Models.Account; 
using EFantasySports.Data; 
using EFantasySports.Models.Game; 

namespace EFantasySports.Controllers
{
    [Route("api/[controller]")]
    public class SettingsController : Controller {
        private readonly GameDbContext context; 
        private readonly UserManager<ApplicationUser> userManager;
        public SettingsController(GameDbContext context, UserManager<ApplicationUser> userManager){
            this.context = context; 
            this.userManager = userManager;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetUser(){
            var user = await userManager.GetUserAsync(HttpContext.User); 
            var manager = new Manager {ManagerID=1, ManagerName="Andrew Kralovec", TeamID=1}; 
            return Json(new { User = user, Manager = manager }); 
        }
    }
}
