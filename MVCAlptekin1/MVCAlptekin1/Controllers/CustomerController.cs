using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCAlptekin1.Entities;
using MVCAlptekin1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCAlptekin1.Services.Logging;

namespace MVCAlptekin1.Controllers
{
    [Route("deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

        [Route("index")]
        [Route("")]
        [Route("~/anasayfa")]
        public IActionResult Index()
        {
            _logger.Log("");
            List<Customer> customer = new List<Customer>
            {
                new Customer{Id=1,FirstName="Alptekin",LastName="Ocakdan",City="Sakarya"},
                new Customer{Id=2,FirstName="Serbil",LastName="Ocakdan",City="Sakarya"},
                new Customer{Id=3,FirstName="Fırat",LastName="Ocakdan",City="Sakarya"}
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };

            var model = new CustomerListViewModel
            {
                Customers = customer,
                Shops = shops
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel 
            { 
                Cities=new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06"},
                    new SelectListItem{Text="İstanbul",Value="34"},
                    new SelectListItem{Text="İzmir",Value="35"}
                }
                
            });
        }

        [HttpPost]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}
