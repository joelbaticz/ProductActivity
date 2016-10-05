using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//poco class
namespace ProductsActivity.Models
{
    public enum ProductTypeEnum
    {
        NEW,
        OLD
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public ProductTypeEnum Type { get; set; }

        public string ToString()
        {
            return Id + " " + Name + " " + Details + " " + Type;
    }

    }

}
