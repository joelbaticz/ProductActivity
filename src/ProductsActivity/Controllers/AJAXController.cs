using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


using ProductsActivity.Services;
using ProductsActivity.ViewModels;
using ProductsActivity.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsActivity.Controllers
{
    public class AJAXController : Controller
    {
        //set up the service
        private IDataService _dataService;

        public AJAXController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            
            return Json(_dataService.GetProducts());
        }

        [HttpPost]
        public JsonResult SaveProduct([FromBody] Product prod)
        {
            if (prod != null)
            {
                _dataService.Add(prod);
                return Json("Added data: " + prod.ToString());
            }
            else
                return Json("Null product");
        }

        [HttpGet]
        public JsonResult FindProduct(int id)
        {
            return Json(_dataService.GetById(id));
        }

    }
}
