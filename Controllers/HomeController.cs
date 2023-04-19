using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SBMfotos.Models;

namespace SBMfotos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

          public IActionResult Info_Sobre()
        {
            return View();
        }

         public IActionResult info_Termos_e_condições_da_loja_online()
        {
            return View();
        }

          public IActionResult Info_FAQ()
        {
            return View();
        }

          public IActionResult Login()
        {
            return View();
        }

          public IActionResult cadastro_no_site()
        {
            return View();
        }

          public IActionResult contato()
        {
            return View();
        }

    



    }
}
