using EricShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Controllers
{
    public class AesopController : Controller
    {
        private readonly IAesopRepository _aesopRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AesopController(IAesopRepository aesopRepository, ICategoryRepository categoryRepository)
        {
            _aesopRepository = aesopRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_aesopRepository.GetAllAesop);
        }

        }
}
