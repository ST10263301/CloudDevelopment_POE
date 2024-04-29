using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudDevelopment.Controllers
{
    public class UserController : Controller
    {
        public tblUsersModel usrtbl = new tblUsersModel();



        [HttpPost]
        public ActionResult About(tblUsersModel Users)
        {
            var result = usrtbl.insert_User(Users);
            //where it must redirect to /view itself      / folder
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usrtbl);
        }

       
    }
}
