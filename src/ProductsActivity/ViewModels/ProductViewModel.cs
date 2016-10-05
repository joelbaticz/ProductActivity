using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsActivity.Models;

namespace ProductsActivity.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public ProductTypeEnum Type { get; set; }
    }
}
