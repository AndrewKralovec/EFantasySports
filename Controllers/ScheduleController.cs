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
    public class ScheduleController : Controller {
        private readonly GameDbContext context ; 
        public ScheduleController(GameDbContext context){
            this.context = context; 
        }
    }
}
