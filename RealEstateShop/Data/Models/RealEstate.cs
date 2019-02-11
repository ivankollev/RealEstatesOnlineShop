using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.Models
{
    public class RealEstate
    {
        public int RealEstateId { get; set; }

        public int Price { get; set; }

        public int SquareMeters { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public bool IsRealEstatePreffered { get; set; }

        public string Type { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; }
    }
}
