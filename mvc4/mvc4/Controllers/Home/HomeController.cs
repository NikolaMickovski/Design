using mvc4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc4.Controllers.Home
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<BikeModel> lista = new List<BikeModel>();
            BikeModel b1 = new BikeModel(){Ime="Tocak1", Model="Model1"};
            BikeModel b2 = new BikeModel() { Ime = "Tocak2", Model = "Model2" };

            lista.Add(b1); lista.Add(b2);


            ViewBag.SomeProperty = "SomeValue";
            
            return View(lista);
        }

        public ActionResult Index2()
        {
            //List<BikeModel> lista = new List<BikeModel>();
            //BikeModel b1 = new BikeModel() { Ime = "Tocak1", Model = "Model1" };
            //BikeModel b2 = new BikeModel() { Ime = "Tocak2", Model = "Model2" };

            //lista.Add(b1); lista.Add(b2);
            //return View("Index", lista);

            return View();
        }
        /// <summary>
        /// Iako View-to Index3 ne e definirano, ovoj metot sosem ke funkcionira
        /// bidejki Index3 vraka drugo View koe e definirano!
        /// </summary>
        /// <returns></returns>
        public ActionResult Index3()
        {
            List<BikeModel> lista = new List<BikeModel>();
            BikeModel b1 = new BikeModel() { Ime = "Tocak1", Model = "Model1" };
            BikeModel b2 = new BikeModel() { Ime = "Tocak2", Model = "Model2" };

            lista.Add(b1); lista.Add(b2);
            return View("Index", lista);

            return View("Index",lista);
        }

    }
}
