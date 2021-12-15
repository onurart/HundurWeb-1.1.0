using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HundurWEB.Controllers
{
    public class ELedgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Einvoice()
        {
            return View();
        }
        public IActionResult Eİrsaliye()
        {
            return View();
        }
    }
}
