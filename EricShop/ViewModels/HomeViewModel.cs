using EricShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Aesop> AesopOnSale { get; set; }
    }
}
