using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> Departments { get; }
    }
}
