using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<RealEstate> PrefferedRealEstates { get; set; }
    }
}
