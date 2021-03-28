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

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(Participant participant)
        {
            // 'Model binding' inside asp core...
            if (ModelState.IsValid)
            {
                Repository.AddParticipant(participant);
                return View("Thanks", participant);
            }
            return View();
        }

        public IActionResult ListParticipant() => View(Repository.Participants);
        
    }
}
