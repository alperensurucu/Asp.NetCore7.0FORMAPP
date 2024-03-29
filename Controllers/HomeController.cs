using Asp.NetCore7._0FORMAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp.NetCore7._0FORMAPP.Controllers
{
    public class HomeController : Controller
    {
    
        public HomeController()
        {
            
        }
         
        public IActionResult Index(string searchString)
        {
            var products = Repository.Products;
            if (!String.IsNullOrEmpty(searchString)) 
            {
                products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
            }
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }  
        
    }
    
}
