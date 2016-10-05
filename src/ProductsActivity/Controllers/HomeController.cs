using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ProductsActivity.Services;
using ProductsActivity.ViewModels;
using ProductsActivity.Models;

namespace ProductsActivity.Controllers
{
    public class HomeController : Controller
    {
        //set up the service
        private IDataService _dataService;

        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //pass data to the view
            ProductsListViewModel vm = new ProductsListViewModel();
            vm.productsList = _dataService.GetProducts();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel vm)
        {
            //check if valid
            if(ModelState.IsValid)
            {
                //mapping from vm to m
                Product p = new Product
                {
                    Name = vm.Name,
                    Details = vm.Details,
                    Type = vm.Type
                };
                //pass to the data service
                _dataService.Add(p);
                //go to home
                return RedirectToAction("Index");
            }
            //if not valid - show errors and return the same page
            return View(vm);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //find the product with id
            Product p = _dataService.GetById(id);

            //mapping from m to vm
            EditProductViewModel vm = new EditProductViewModel
            {
                Name = p.Name,
                Details = p.Details,
                Type = p.Type  
            };

            //pass it to the view
            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(int id, EditProductViewModel vm)
        {
            //find the product with id
            Product p = _dataService.GetById(id);

            if(p != null && ModelState.IsValid)
            {
                //mapping-updating from vm to m
                p.Name = vm.Name;
                p.Details = vm.Details;
                p.Type = vm.Type;

                //update the product
                _dataService.Update();
                //go home
                return RedirectToAction("Index");
            }
            //if not valid - show errors and return the same page
            return View(vm);
        }
    }
}
