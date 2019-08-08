using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrelloClone.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}