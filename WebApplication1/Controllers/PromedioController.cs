using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class PromedioController : Controller
    {
        // GET: Promedio
      
        
        public ActionResult Index()
           
        {
            
            if (Request.HttpMethod == "POST")
            {
                ViewBag.Nombre = Request["nombre"];
                ViewBag.Grado = Request["grado"];
                var mnota1 = Convert.ToDouble(Request["Mnota1"]);
                var Mnota2 = Convert.ToDouble(Request["Mnota2"]);
                var Mnota3 = Convert.ToDouble(Request["Mnota3"]);
                var Cnota1 = Convert.ToDouble(Request["Cnota1"]);
                var Cnota2 = Convert.ToDouble(Request["Cnota2"]);
                var Cnota3 = Convert.ToDouble(Request["Cnota3"]);
                var Lnota1 = Convert.ToDouble(Request["Lnota1"]);
                var Lnota2 = Convert.ToDouble(Request["Lnota2"]);
                var Lnota3 = Convert.ToDouble(Request["Lnota3"]);
                var Tnota1 = Convert.ToDouble(Request["Tnota1"]);
                var Tnota2 = Convert.ToDouble(Request["Tnota2"]);
                var Tnota3 = Convert.ToDouble(Request["Tnota3"]);
                double pm, pc, pl, pt;
                pm = ((mnota1 * 0.33) + (Mnota2 * 0.33) + (Mnota3 * 0.34));
                if (pm >= 7)
                {
                    ViewBag.estadoM = "Aprobado";

                }
                else
                {
                    ViewBag.estadoM = "Reprobado";
                }
                pc = ((Cnota1 * 0.33) + (Cnota2 * 0.33) + (Cnota3 * 0.34));
                if (pc >= 7)
                {
                    ViewBag.estadoC = "Aprobado";

                }
                else
                {
                    ViewBag.estadoC = "Reprobado";
                }
                pl = ((Lnota1 * 0.33) + (Lnota2 * 0.33) + (Lnota3 * 0.34));
                if (pl >= 7)
                {
                    ViewBag.estadoL = "Aprobado";

                }
                else
                {
                    ViewBag.estadoL = "Reprobado";
                }
                pt = ((Tnota1 * 0.33) + (Tnota2 * 0.33) + (Tnota3 * 0.34));
                if (pt >= 7)
                {
                    ViewBag.estadoT = "Aprobado";

                }
                else
                {
                    ViewBag.estadoT = "Reprobado";
                }
                var CUM = ((pm) + (pc) + (pl) + (pt)/4);
                ViewBag.PromedioMate = pm;
                ViewBag.b = pc;
                ViewBag.c = pl;
                ViewBag.d = pt;
                
                ViewBag.PromedioLenguaje = pl;
                ViewBag.PromedioCiencias = pc;
                ViewBag.PromedioTecnologia = pt;
                ViewBag.cum = CUM;
                return View("Promedios");

            }
            return View();
        }
        
        public ActionResult Promedios()
        {
            return View();
        }
    }
}