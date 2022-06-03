using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIN.Controllers
{
    public class CartaoCredito : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
