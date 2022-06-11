using Microsoft.AspNetCore.Mvc;
using WebEnkom.DAL.Interfaces;
using WebEnkom.DAL;
using WebEnkom.Domain.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebEnkom.Controllers
{
    public class BasketController : Controller
    {
        IDiscountRepository _discountRepository;
        IDeliveryRepository _deliveryRepository;
        ApplicationDbContext _context;
        IOrderRepository _orderRepository;
        IOverallRepository _overallRepository;

        public BasketController(IDiscountRepository discountRepository,
                                ApplicationDbContext context,
                                IDeliveryRepository deliveryRepository,
                                IOrderRepository orderRepository,
                                IOverallRepository overallRepository)
        {
            _discountRepository = discountRepository;
            _context = context;
            _deliveryRepository = deliveryRepository;
            _orderRepository = orderRepository;
            _overallRepository = overallRepository;
        }

        [HttpGet]
        public IActionResult Basket()
        {
            return View(_discountRepository);
        }

        [HttpPost]
        public IActionResult ClearBasket()
        {
            Information.Basket.Products.Clear();
            return RedirectToAction("Basket");
        }

        [HttpGet]
        public IActionResult Delivery()
        {
            if (Information.Basket.Products.Count == 0)
            {
                return Redirect("/Shop/ChooseType");
            }
            return View(_deliveryRepository);
        }

        [HttpPost]
        public IActionResult Delivery(string area, string street, string house, int? flat)
        {
            int deliveryId = _deliveryRepository.GetByArea(area).Id;

            var order = new Order()
            {
                CustomerId = Information.Customer.Id,
                DeliveryId = deliveryId,
                Street = street,
                House = house,
                Flat = flat
            };

            _orderRepository.Create(order);

            foreach(var item in Information.Basket.Products)
            {
                var overall = new Overall()
                {
                    OrderId = order.Id,
                    ProductId = item.Product.Id,
                    Amount = item.Amount
                };

                _overallRepository.Create(overall);
            }

            return Redirect("/Shop/ChooseType");
        }
    }
}
