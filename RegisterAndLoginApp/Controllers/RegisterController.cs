using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;

namespace RegisterAndLoginApp.Controllers
{
    public class RegisterControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterDetails(Register user)
        {
            SecurityDAO securityService = new SecurityDAO();

            return View(securityService.RegisterUser(user));
        }
    }
}
