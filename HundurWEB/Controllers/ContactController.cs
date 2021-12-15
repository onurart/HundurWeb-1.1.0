using HundurWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundurWEB.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModels model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Adınız: " + model.Name);
                body.AppendLine("Soyadınız: " + model.LastName);
                body.AppendLine("Phone: " + model.Phone);
                body.AppendLine("Email: " + model.Email);
                body.AppendLine("Message: " + model.Message);
                Contact.SendMail(body.ToString());
                ViewBag.Success = true;
            }
            return View();
        }


    }
}
