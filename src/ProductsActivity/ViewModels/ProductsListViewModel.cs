using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsActivity.Models;

namespace ProductsActivity.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> productsList { get; set; }
    }
}
