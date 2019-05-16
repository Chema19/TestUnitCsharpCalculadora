using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Matematica.ViewModels;

namespace CRUD_Matematica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new IndexViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel model)
        {
            try
            {
                if (!String.IsNullOrEmpty(model.Contrasenia) && !String.IsNullOrEmpty(model.Usuario))
                {
                    return RedirectToAction("About", "Home");
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                var vm = new IndexViewModel();
                return View(vm);
            }
        }

        public ActionResult About(AboutViewModel model)
        {
            //var vm = new AboutViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Sumar(AboutViewModel model)
        {
            var resultado = Suma(model.InputSuma1, model.InputSuma2);
            ViewBag.Message = resultado;
            var vm = new AboutViewModel();
            vm.Fill(model.InputSuma1, model.InputSuma2, resultado, "S");
            Session["mensaje"] = "Success";
            return RedirectToAction("About", "Home", vm);
        }

        [HttpPost]
        public ActionResult Restar(AboutViewModel model)
        {
            var resultado = Resta(model.InputResta1, model.InputResta2);
            ViewBag.Message = resultado;
            var vm = new AboutViewModel();
            vm.Fill(model.InputResta1, model.InputResta2, resultado, "R");
            Session["mensaje"] = "Success";
            return RedirectToAction("About", "Home", vm);
        }

        [HttpPost]
        public ActionResult Multiplicar(AboutViewModel model)
        {
            var resultado = Multiplicacion(model.InputMultiplicacion1, model.InputMultiplicacion2);
            ViewBag.Message = resultado;
            var vm = new AboutViewModel();
            vm.Fill(model.InputMultiplicacion1, model.InputMultiplicacion2, resultado, "M");
            Session["mensaje"] = "Success";
            return RedirectToAction("About", "Home", vm);
        }

        [HttpPost]
        public ActionResult Dividir(AboutViewModel model)
        {
            if (model.InputDivision2 == 0) {
                Session["mensaje"] = "Error no se puede dividir por cero";
                return RedirectToAction("About", "Home", model);
            }
            var resultado = Division(model.InputDivision1, model.InputDivision2);
            ViewBag.Message = resultado;
            var vm = new AboutViewModel();
            vm.Fill(model.InputDivision1, model.InputDivision2, resultado, "D");
            Session["mensaje"] = "Success";
            return RedirectToAction("About", "Home", vm);
        }


        public Decimal? Suma(Decimal? valor1, Decimal? valor2)
        {
            return valor1 + valor2;
        }
        public Decimal? Resta(Decimal? valor1, Decimal? valor2)
        {
            return valor1 - valor2;
        }
        public Decimal? Multiplicacion(Decimal? valor1, Decimal? valor2)
        {
            return valor1 * valor2;
        }
        public Decimal? Division(Decimal? valor1, Decimal? valor2)
        {
            return valor1 / valor2;
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}