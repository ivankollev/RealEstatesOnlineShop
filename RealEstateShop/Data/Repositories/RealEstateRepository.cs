using Microsoft.EntityFrameworkCore;
using RealEstateShop.Data.interfaces;
using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.Repositories
{
    public class RealEstateRepository : IRealEstateRepository
    {
        private readonly AppDbContext _appDbContext;

        public RealEstateRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<RealEstate> RealEstates => _appDbContext.RealEstates.Include(c => c.Category);

        public IEnumerable<RealEstate> PreferredRealEstates => _appDbContext.RealEstates.Where(p => p.IsRealEstatePreffered).Include(c => c.Category);

        public RealEstate GetRealEstateById(int realEstateId) => _appDbContext.RealEstates.FirstOrDefault(p => p.RealEstateId == realEstateId);
    }
}
