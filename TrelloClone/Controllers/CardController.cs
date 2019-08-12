using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrelloClone.ViewModel;

namespace TrelloClone.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        public IActionResult Details(int id)
        {
            var viewModel = new CardDetails 
            {
                Id = id,
                Contents = "Put the washing out",
                Notes = "But not if it's raining"
            };

            return View(viewModel);
        }
    }
}