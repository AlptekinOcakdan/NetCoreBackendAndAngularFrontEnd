using Microsoft.AspNetCore.Mvc;
using MVCAlptekin1.Entities;
using MVCAlptekin1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAlptekin1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Index2(int id)
        {
            return id.ToString();
        }
        
    }
}
