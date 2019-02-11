using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int RealEstateId { get; set; }

        public decimal Price { get; set; }

        public virtual RealEstate RealEstate { get; set; }

        public virtual Order Order { get; set; }
    }
}
