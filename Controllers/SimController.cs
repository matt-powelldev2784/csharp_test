using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Real_Digital_Sim_Stock.Controllers
{
    public class SimController : Controller
    {
        private readonly ISimRepo _SimRepo;

        public SimController(ISimRepo SimRepo)
        {
            _SimRepo = SimRepo;
        }

        public IActionResult List()
        {
            ViewBag.IsActivated = true;
            return View(_SimRepo.GetAll());
        }
    }
}

