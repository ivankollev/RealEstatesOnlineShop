using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstateShop.Data.interfaces;
using RealEstateShop.Data.Models;
using RealEstateShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstateShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IRealEstateRepository _realEstateRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IRealEstateRepository realEstateRepository, ShoppingCart shoppingCart)
        {
            _realEstateRepository = realEstateRepository;
            _shoppingCart = shoppingCart;
        }
     

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int realEstateId)
        {
            var selectedRealEstate = _realEstateRepository.RealEstates.FirstOrDefault(p => p.RealEstateId == realEstateId);

            if (selectedRealEstate != null)
            {
                _shoppingCart.AddToCart(selectedRealEstate);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int realEstateId)
        {
            var selectedRealEstate = _realEstateRepository.RealEstates.FirstOrDefault(p => p.RealEstateId == realEstateId);

            if (selectedRealEstate != null)
            {
                _shoppingCart.RemoveFromCart(selectedRealEstate);
            }
            return RedirectToAction("Index");
        }
    }
}
