using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//..
using ProductsActivity.Models;

namespace ProductsActivity.Services
{
    public interface IDataService
    {
        IEnumerable<Product> GetProducts();

        void Add(Product aProduct);

        Product GetById(int id);

        int Update();
    }
}
