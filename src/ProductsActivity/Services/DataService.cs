using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsActivity.Models;

namespace ProductsActivity.Services
{
    public class DataService : IDataService
    {
        private static List<Product> _products;

        static DataService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name="PC", Details="Dell Win10 PC", Type=ProductTypeEnum.NEW },
                new Product { Id = 2, Name="Laptop", Details="HP Win10 PC", Type=ProductTypeEnum.NEW },
                new Product { Id = 3, Name="PC", Details="MS Win10 PC", Type=ProductTypeEnum.OLD },
                new Product { Id = 4, Name="PC", Details="Apple Mac", Type=ProductTypeEnum.NEW },
            };
        }

        public void Add(Product aProduct)
        {
            _products.Add(aProduct);
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public int Update()
        {
            //this will be some code when we use database
            return 0;
        }
    }
}
