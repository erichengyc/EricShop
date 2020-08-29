using EricShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.ViewModels
{
    public class AesopListViewModel
    {
        public IEnumerable<Aesop> Aesops { get; set; }
        public string CurrentCategory { get; set; }
    }
}
