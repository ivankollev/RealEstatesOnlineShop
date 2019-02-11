using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstateShop.Data.interfaces;
using RealEstateShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstateShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRealEstateRepository _realEstateRepository;

        public HomeController(IRealEstateRepository realEstateRepository)
        {
            _realEstateRepository = realEstateRepository;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PrefferedRealEstates = _realEstateRepository.PreferredRealEstates
            };
            return View(homeViewModel);
        }
    }
}
