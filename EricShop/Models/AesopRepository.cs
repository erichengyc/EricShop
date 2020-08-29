using Microsoft.EntityFrameworkCore;
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
        private readonly AppDbContext _appDbContext;
        public AesopRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Aesop> GetAllAesop
        {
            get
            {
                return _appDbContext.Aesops.Include(c => c.Category);
            }
        }

        public IEnumerable<Aesop> GetAesopOnSale
        {
            get
            {
                return _appDbContext.Aesops.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Aesop GetAesopById(int aesopId)
        {
            return GetAllAesop.FirstOrDefault(c => c.AesopId == aesopId);
        }
    }
}
