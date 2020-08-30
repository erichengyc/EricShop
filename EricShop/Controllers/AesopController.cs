using EricShop.Models;
using EricShop.ViewModels;
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

        public ViewResult List(string category)
        {
            IEnumerable<Aesop> aesops;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                aesops = _aesopRepository.GetAllAesop.OrderBy(c => c.AesopId);
                currentCategory = "All Aesop";
            }
            else
            {
                aesops = _aesopRepository.GetAllAesop.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new AesopListViewModel
            {
                Aesops = aesops,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var aesop = _aesopRepository.GetAesopById(id);
            if (aesop == null)
                return NotFound();

            return View(aesop);
        }
    }
}
