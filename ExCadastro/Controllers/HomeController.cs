using ExCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExCadastro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var produto = new Produto();
            return View(produto);
        }
        [HttpPost]

        public ActionResult Index(Produto produto)
        {
            if (ModelState.IsValid)
            {
                return View("Registro", produto);
            }
            return View(produto);
        }

        public ActionResult Registro(Produto produto)
        {
            return View(produto);
        }
    }
}