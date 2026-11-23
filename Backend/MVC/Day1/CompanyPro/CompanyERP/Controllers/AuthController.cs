using CompanyERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace CompanyERP.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        // 2 action , 1 view
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            if (!ModelState.IsValid || registerVM.Password!=registerVM.ConfirmPassword)
            {
                return View("Register", registerVM);
            }

            var appUser = new ApplicationUser()
            {
                Address = registerVM.Address,
                PhoneNumber = registerVM.Phone,
                Email = registerVM.Email,
                PasswordHash = registerVM.Password,
                UserName = registerVM.Username
            };

            //UserManager userManager = new Microsoft.AspNetCore.Identity.UserManager() // create
            // inject userManager
            var identityResult = await userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach(var error in identityResult.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return View("Register", registerVM);
            }

            //SignInManager signInManager = new Microsoft.AspNetCore.Identity.SignInManager()// create
            await signInManager.SignInAsync(appUser, false);

            return RedirectToAction("GetDepartments", "Department");
        }
    }
}
