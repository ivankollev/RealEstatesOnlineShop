using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public List<RealEstate> RealEstates { get; set; }
    }
}
