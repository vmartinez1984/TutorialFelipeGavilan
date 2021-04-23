using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tutorial01.Models;
using Tutorial01.Services;

namespace Tutorial01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IRepositorioPais RepositorioPais;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IRepositorioPais repositorioPais)
        {
            this.RepositorioPais = repositorioPais;
        }

        public IActionResult Index()
        {
            //throw new ApplicationException("Ha ocurrido algo malo");
            List<string> paises;

            paises = this.RepositorioPais.ObtenerTodos();

            return View(paises);
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
    }
}
