using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EdadController : Controller
    {
        // GET: Edad
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtNombre, int txtEdad)
        {
            var datos = new Operaciones();
            int res = datos.Edad(txtEdad);
            // es lo mismo que //Operaciones obj = new Operaciones();
            if(res >= 18) { 
            ViewBag.Edad= txtNombre +  " tienes " +  res + " años, eres mayor";
            return View();
            }
            else
            {
                ViewBag.Edad = txtNombre + " tienes " + res + " años, eres menor";
                return View();
            }


        }
    }
}