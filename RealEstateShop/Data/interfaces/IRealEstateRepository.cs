using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.interfaces
{
    public interface IRealEstateRepository
    {
        IEnumerable<RealEstate> RealEstates { get; }

        IEnumerable<RealEstate> PreferredRealEstates { get; }

        RealEstate GetRealEstateById(int realEstateId);
    }
}
