using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Cleanse",CategoryDescription = "Cleansing skin of daily grime, sweat and other " +
                "impurities forms the foundation of an intelligent skin care regimen."},
            new Category{CategoryId=2,CategoryName="Hydrate",CategoryDescription = "Essential for skin’s optimal health and appearance, " +
                "hydrating replenishes moisture, nourishes, soothes and sustains skin."},
            new Category{CategoryId=3,CategoryName="Shave",CategoryDescription = "Formulations and tools to furnish a regimen that " +
                "prizes a razor-close shave, calm, fresh and supple skin."},
        };
    }
}
