using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public class AesopRepository : IAesopRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Aesop> GetAllAesop => new List<Aesop>
        {
            new Aesop {AesopId = 1, Name="Purifying Facial Cream Cleanser", Price = 37.00M, Description="A mild preparation enhanced " +
                "with White Clay and fatty-acid rich botanicals to gently cleanse and effortlessly remove surface impurities.",
                Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/15/150/1419/110/8/607280500_877696220/607280500_877696220_1_1_720x928.jpg",
                IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/15/150/1419/110/8/607280500_877696220/607280500_877696220_1_1_720x928.jpg"},

            new Aesop {AesopId = 2, Name="In Two Minds Facial Hydrator", Price = 60.00M, Description="A rapidly absorbed formulation that delivers lightweight hydration with a matte finish, ideal for combination skin.",
                Category = _categoryRepository.GetAllCategories.ToList()[1], ImageUrl="https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/15/150/1419/110/8/635995630/635995630_1_1_720x928.jpg",
                IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/15/150/1419/110/8/635995630/635995630_1_1_720x928.jpg"},

            new Aesop {AesopId = 3, Name="Moroccan Neroli Post-Shave Lotion", Price = 55.00M, Description="A unisex hydrator boosted with botanical oils that lightly hydrate and balance skin while pacifying post-shave irritation and aggravation.",
                Category = _categoryRepository.GetAllCategories.ToList()[1], ImageUrl="https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/15/150/1419/110/8/899948450_900001910/899948450_900001910_1_720x928.jpg",
                IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/15/150/1419/110/8/899948450_900001910/899948450_900001910_1_720x928.jpg"}
        };

        public IEnumerable<Aesop> GetAesopOnSale => throw new NotImplementedException();

        public Aesop GetAesopById(int aesopId)
        {
            return GetAllAesop.FirstOrDefault(c => c.AesopId == aesopId);
        }
    }
}
