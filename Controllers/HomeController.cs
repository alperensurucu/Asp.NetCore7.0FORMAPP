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

        public IActionResult Index()
        {
            return View(Repository.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }  
        
    }

}
