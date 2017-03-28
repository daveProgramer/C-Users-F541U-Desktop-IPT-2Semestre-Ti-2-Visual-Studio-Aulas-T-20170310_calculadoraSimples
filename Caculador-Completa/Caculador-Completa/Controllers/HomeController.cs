using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caculador_Completa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home
        [HttpPost]
        public ActionResult Index(
            int operando1,
            char operador,
            int operando2)
        {

            int resultado;

            switch (operador)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case 'x':
                    resultado = operando1 * operando2;
                    break;
                case ':':
                    resultado = operando1 / operando2;
                    break;
            }


            return View();
        }


    }
}