using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;
using WebEnkom.Models;

namespace WebEnkom.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ISexRepository _sexRepository;
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IProductRepository _productRepository;



        public ShopController(ICustomerRepository customerRepository,
                                  ISexRepository sexRepository,
                                  IProductTypeRepository productTypeRepository,
                                  IProductRepository productRepository)
        {
            _customerRepository = customerRepository;
            _sexRepository = sexRepository;
            _productTypeRepository = productTypeRepository;
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(_sexRepository.Select());
        }

        [HttpPost]
        public IActionResult Registration(string Name, string Surname,
                                        string Fathername, string Tel,
                                        string Password, string Sex)
        {
            var person = _customerRepository.GetByTel(Tel);
            if (person == null)
            {
                var customer = new Customer()
                {
                    Name = Name,
                    Surname = Surname,
                    Fathername = Fathername,
                    Tel = Tel,
                    Password = Password,
                    SexId = _sexRepository.GetByName(Sex).Id,
                    DiscountId = 1
                };
                _customerRepository.Create(customer);
            }
            return RedirectToAction("Autentification");
        }


        [HttpGet]
        public IActionResult ChooseType()
        {
            return View(_productTypeRepository.Select());
        }

        [HttpGet]
        public IActionResult Products(int typeId)
        {
            var products = _productRepository.Select().Where(x => x.TypeId == typeId).ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult Products(int typeId, int productId, int amount)
        {
            AddToBasket(productId, amount);
            var products = _productRepository.Select().Where(x => x.TypeId == typeId).ToList();
            return View(products);
        }

        public void AddToBasket(int productId, int amount)
        {
            var product = _productRepository.Get(productId);
            Information.Basket.Add(product, amount);
        }
    }
}
