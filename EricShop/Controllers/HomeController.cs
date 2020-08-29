using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EricShop.Models;
using EricShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EricShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAesopRepository _aesopRepository;

        public HomeController(IAesopRepository aesopRepository)
        {
            _aesopRepository = aesopRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AesopOnSale = _aesopRepository.GetAesopOnSale
            };

            return View(homeViewModel);
        }
    }
}
