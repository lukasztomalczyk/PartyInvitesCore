using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult FormRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormRegistration(GuestResponse _guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", _guestResponse);
            }
            else
            {
                return View();
            }

        }

        public IActionResult Index()
        {
           return View();
        }

    }
}
