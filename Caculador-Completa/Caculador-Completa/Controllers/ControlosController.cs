using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caculador_Completa.Controllers
{
    public class ControlosController : Controller
    {
      
        // GET: Controlos
        public ActionResult Index(string bt, string visor)
        {
            ViewBag.Visor = 0;
            switch (bt) {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    //determinar se n  VISOR só existe um zero
                    if (visor.Equals("0")) visor = bt;
                    else visor += bt; // visor = visor + bt;
                    break;
                case ",":
                    if (!visor.Contains(",")) visor += ",";
                    break;

                case "+/-":
                    //visor = Convert.ToDouble(visor) * -1 + "";
                    if (visor.StartsWith("-")) visor = visor.Replace("-", "");
                    else if (!visor.Equals("0")) visor = "-" + visor;
                    //else visor = "-" + visor;
                    break;

                case "C":
                    visor = "0";
                    Session["PrimeiorOperador"] = true;
                    break;

                case "+":
                case "-":
                case "x":
                case ":":
                    if ((bool)Session["PrimeiorOperador"])
                    {
                        //guardar valor do VISOR
                        Session["operando"] = visor;

                        //limpar visor
                        visor = "0";
                        Session["PrimeiorOperador"] = true;

                        //guardar o OPERADOR
                        Session["operador"] = bt;

                        //marcar com tendo utilizado o operador
                        Session["PrimeiorOperador"] = false;

                    }
                    else {

                        /*se não é a primeira vez que estpou a clicar num operador 
                         * vou utilizar os valores anteriores*/
                        switch ((string)Session["operador"]) {
                            //recuperar código da 1ª Calculadora

                        }

                        //guardar os novos valores...
                    }

                   
                    break;

            }
            //entrgar os valores à VIEW
            ViewBag.Visor = visor;


            return View();
        }
    }
}