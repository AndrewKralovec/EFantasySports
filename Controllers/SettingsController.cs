using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFantasySports.Models.Account; 
using EFantasySports.Data; 
using EFantasySports.Models.Game;
using EFantasySports.Models.Utility; 

namespace EFantasySports.Controllers
{
    [Route("api/[controller]")]
    public class SettingsController : Controller {
        private readonly GameDbContext context; 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger logger;
        private readonly Manager manager; 
        public SettingsController(
            GameDbContext context, 
            UserManager<ApplicationUser> userManager, 
            ILoggerFactory logger
            ){
            this.context = context; 
            this.logger = logger.CreateLogger<SettingsController>();
            this.userManager = userManager;
            this.manager = new Manager {ManagerID=1, ManagerName="Andrew Kralovec", TeamID=1}; 
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetUser(){
            var user = await userManager.GetUserAsync(HttpContext.User); 
            return Json(new { User = user, Manager = manager }); 
        }
        public async Task<IActionResult> UpdateManager(Manager manager){
            GameResponse result = null; 
            if (ModelState.IsValid){
                try {
                    context.Update(manager);
                    await context.SaveChangesAsync();
                    result = new GameResponse(true, ""); 
                }
                catch (DbUpdateException ex){
                    logger.LogError("Update exception in Settings Controller", ex); 
                    result = new GameResponse(false, ex.ToString()); 
                }
            }
            return Json(new {
                    Response = result
            });
        }
    }
}
