using System.Collections.Generic;
using WebEnkom.Domain.Entity;
using System.Linq;

namespace WebEnkom.Models
{
    public class Basket
    {
        public List<BasketItem> Products { get; set; } = new List<BasketItem>();

        public void Add(Product product, int amount)
        {
            if (Products == null)
            {
                var basketItem = new BasketItem
                {
                    Product = product,
                    Amount = amount
                };
                Products.Add(basketItem);
            }
            else
            {
                var result = Products.Where(x => x.Product.Name == product.Name).FirstOrDefault();

                if (result == null)
                {
                    var basketItem = new BasketItem
                    {
                        Product = product,
                        Amount = amount
                    };
                    Products.Add(basketItem);
                }
                else
                {
                    Products.Where(x => x.Product.Name == product.Name).
                             FirstOrDefault().
                             Amount += amount;
                }
            }
        }

        public void Delete(BasketItem item)
        {
            Products.Remove(item);
        }
    }

    public class BasketItem
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
