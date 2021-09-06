using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tp02_taller.Models;
using tp02_taller.Entities;

namespace tp02_taller.Controllers
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

        public string problema01(string name, string lastname, string dni, string addres, string job, DateTime birthday, DateTime entryCompany)
        {
            try
            {
                Employee empleado = new Employee(name,lastname,dni,addres,job,birthday,entryCompany);
                return $"Apellido y Nombre: {empleado.Lastname} {empleado.Name} \tEdad:{empleado.Age} \nPuesto:{empleado.Job} \nSalario: {empleado.Salary}";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
