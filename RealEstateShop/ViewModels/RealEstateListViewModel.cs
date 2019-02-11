using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.ViewModels
{
    public class RealEstateListViewModel
    {
        public IEnumerable<RealEstate> RealEstates { get; set; }

        public string CurrentCategory { get; set; }
    }
}
