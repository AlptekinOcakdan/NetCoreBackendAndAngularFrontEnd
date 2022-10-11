using Microsoft.AspNetCore.Mvc.Rendering;
using MVCAlptekin1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAlptekin1.Models
{
    public class SaveCustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
