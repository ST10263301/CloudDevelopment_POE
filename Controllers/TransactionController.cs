﻿using Microsoft.AspNetCore.Mvc;

namespace CloudDevelopment.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
