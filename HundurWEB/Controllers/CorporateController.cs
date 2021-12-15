using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HundurWEB.Controllers
{
    public class CorporateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Sustainability()
        {
            return View();
        }
        public IActionResult HumanResources()
        {
            return View();
        }
    }
}
