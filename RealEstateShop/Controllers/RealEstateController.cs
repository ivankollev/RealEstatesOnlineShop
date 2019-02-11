using Microsoft.AspNetCore.Mvc;
using RealEstateShop.Data.interfaces;
using RealEstateShop.Data.Models;
using RealEstateShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Controllers
{
    public class RealEstateController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRealEstateRepository _realEstateRepository;

        public RealEstateController(IDepartmentRepository departmentRepository, ICategoryRepository categoryRepository, IRealEstateRepository realEstateRepository)
        {
            _departmentRepository = departmentRepository;
            _categoryRepository = categoryRepository;
            _realEstateRepository = realEstateRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<RealEstate> realEstates;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                realEstates = _realEstateRepository.RealEstates.OrderBy(r => r.RealEstateId);
                currentCategory = "All Real Estates";
            }
            else
            {
                realEstates = _realEstateRepository.RealEstates.Where(r => r.Category.Description.Equals(_category));
                currentCategory = _category;
            }

            var realEstateListViewModel = new RealEstateListViewModel
            {
                RealEstates = realEstates,
                CurrentCategory = currentCategory
            };
            return View(realEstateListViewModel);
        }
    }
}
