using Microsoft.AspNetCore.Mvc;
using Project35_BasicMVC.Models;

#region 5.controller oluşturma
//customerorderscontroller oluşturuyoruz
//Controller, iş mantığını yönetir ve model ile view arasında köprü kurar. 
namespace Project35_BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        //index methodu oluşturuyoruz
        public IActionResult Index()
        {
            //Örnek bir Customer nesnesi ve birkaç Order nesnesi oluşturuyoruz.
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Eda",
                LastName = "Ozge",
                Email = "eda.ozge@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Avize", Price = 1500, Quantity = 5 },
                new Order { Id = 2, ProductName = "Masa", Price = 3000, Quantity = 2 },
                new Order { Id = 3, ProductName = "Sandalye", Price = 2000, Quantity = 4 },
                new Order { Id = 4, ProductName = "Koltuk Takımı", Price = 30000, Quantity = 1},
                new Order { Id = 5, ProductName = "Halı", Price = 2800, Quantity = 5 }

            };


            //CustomerOrderViewModel nesnesini view'a iletiyoruz
            var viewModel = new CustomerOrdersViewModel
            {
                Customer = customer,
                Order = orders
            }; 
            return View(viewModel);
        }
    }
}

#endregion
