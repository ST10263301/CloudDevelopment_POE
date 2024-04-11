using Microsoft.AspNetCore.Mvc;

namespace CloudDevelopment.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
