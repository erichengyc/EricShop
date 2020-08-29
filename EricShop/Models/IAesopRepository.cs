using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public interface IAesopRepository
    {
        IEnumerable<Aesop> GetAllAesop { get; }
        IEnumerable<Aesop> GetAesopOnSale { get; }
        Aesop GetAesopById(int aesopId);
    }
}
