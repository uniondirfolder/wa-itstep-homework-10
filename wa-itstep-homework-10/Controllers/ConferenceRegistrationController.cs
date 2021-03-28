using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wa_itstep_homework_10.Models;

namespace wa_itstep_homework_10.Controllers
{
    public class ConferenceRegistrationController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Time = DateTime.Now;
            return View("Index");
        }

        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(Participant participant)
        {
            //TODO: Do something with registration info
            return View();
        }
        
    }
}
