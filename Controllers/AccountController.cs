using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFantasySports.Models.Account; 
using EFantasySports.Models.Utility; 

namespace EFantasySports.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller {
        // Account services 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger logger;
        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory logger
        ){
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger.CreateLogger<AccountController>();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] AccountRegister model) {
            try {
                AccountResponse response = null; 
                if (ModelState.IsValid) {
                    var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded) {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        logger.LogInformation(3, "User created a new account with password.");
                        return Json(response = new AccountResponse(true, "New user Account created"));
                    }
                    return Json(response = new AccountResponse(false, result.Errors.ToList()));
                }
                return Json(response = new AccountResponse(false, ModelState));
            } catch (Exception ex) {
                logger.LogError("Register exception in Account Controller", ex); 
                return BadRequest(); 
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] AccountLogin model) {
            try {
                AccountResponse response = null; 
                if (ModelState.IsValid) {
                    var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded) {
                        logger.LogInformation(1, "User logged in.");
                        // var b = await userManager.FindByEmailAsync(model.Email);
                        return Json(response = new AccountResponse(true, "User logged in.")); 
                    }
                    if (result.RequiresTwoFactor) {
                        return Json(response = new AccountResponse(false, "Login requiest two factor")); 
                    }
                    if (result.IsLockedOut) {
                        logger.LogWarning(2, "User account locked out.");
                        return Json(response = new AccountResponse(false, "User account locked out")); 
                    }
                    else {
                        return Json(response = new AccountResponse(false, "Invalid login attempt")); 
                    }
                }
                return Json(response = new AccountResponse(false, ModelState)); 
            } catch (Exception ex){
                logger.LogError("Login exception in Account Controller", ex); 
                return BadRequest(); 
                // return BadRequest(new { ErrorMessage = "Account is locked." }); 
            }
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> LogOff() {
            await signInManager.SignOutAsync();
            logger.LogInformation(4, "User logged out.");
            return Json("Logged out"); 
        }
    }
}
