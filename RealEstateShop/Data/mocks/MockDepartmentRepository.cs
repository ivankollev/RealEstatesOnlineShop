using RealEstateShop.Data.interfaces;
using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.mocks
{
    public class MockDepartmentRepository:IDepartmentRepository
    {
        public IEnumerable<Department> Departments {
            get
            {
                return new List<Department>
                    {
                        new Department { Name = "South", Description = "South Department" },
                        new Department { Name = "North", Description = "North Department" }
                    };
            }
        }
    }
}
