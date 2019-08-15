using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrelloClone.Services;
using TrelloClone.ViewModel;

namespace TrelloClone.Controllers
{
    public class CardController : Controller
    {
        private readonly CardService _cardService;

        public CardController(CardService cardService)
        {
            _cardService = cardService;
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var viewModel = _cardService.GetDetails(id);

            return View(viewModel);
        }
    }
}