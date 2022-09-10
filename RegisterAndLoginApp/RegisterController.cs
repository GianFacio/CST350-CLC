using RegisterAndLoginApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace RegisterAndLoginApp.Controllers
{
    public class RegisterController : Controller
    {
        public RegisterController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterDetails(Register register)
        {
            return View(register);
        }

        
    }
}
