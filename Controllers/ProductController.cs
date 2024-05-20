using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudDevelopment.Controllers
{
    public class ProductController : Controller
    {
        public tblProductsModel prodtbl = new tblProductsModel();



        [HttpPost]
        public ActionResult MyWork(tblProductsModel products)
        {
            var result2 = prodtbl.insert_product(products);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult MyWork()
        {
            return View(prodtbl);
        }
    }

}
