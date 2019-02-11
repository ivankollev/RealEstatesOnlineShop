using RealEstateShop.Data.interfaces;
using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly IDepartmentRepository _departmentRepository = new MockDepartmentRepository();

        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                {
                    new Category {
                        Name = "East",
                        Description = "East part of southern Bulgaria",
                        Department = _departmentRepository.Departments.First()
                    },
                     new Category {
                        Name = "Middle",
                        Description = "Middle part of southern Bulgaria",
                        Department = _departmentRepository.Departments.First()
                    },
                    new Category {
                        Name = "West",
                        Description = "West part of southern Bulgaria",
                        Department = _departmentRepository.Departments.First()
                    },
                    new Category {
                        Name = "East",
                        Description = "East part of northern Bulgaria",
                        Department = _departmentRepository.Departments.Last()
                    },
                    new Category {
                        Name = "Middle",
                        Description = "Middle part of northern Bulgaria",
                        Department = _departmentRepository.Departments.Last()
                    },
                    new Category {
                        Name = "West",
                        Description = "West part of northern Bulgaria",
                        Department = _departmentRepository.Departments.Last()
                    }
                };
            }
        }
    }
}
