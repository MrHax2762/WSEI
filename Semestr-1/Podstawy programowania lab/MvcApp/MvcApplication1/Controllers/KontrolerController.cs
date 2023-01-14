using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class KontrolerController : Controller
    {
        //
        // GET: /Kontroler/

        public string Domyslny(string parametr)
        {
            ViewBag.Message = "Tekst";

            return "Tekst bez uzywania widoku !" + parametr;
        }

        public ActionResult Widok()
        {
            return View();
        }


        [HttpPost]  // sygnatura post z formularza
        public ActionResult Widok(Widok widok)
        {
            if (ModelState.IsValid){

                string dane1 = widok.Dane1; // przetwarzanie danych z modelu
                TempData["Dane1"] = widok.Dane1;
                TempData["Dane2"] = widok.Dane2;

                return RedirectToAction("Potwierdzenie", "Kontroler");
            }
            return View();
        }

        public ActionResult Potwierdzenie(string dane1, string dane2)
        {
            ViewBag.Dane1 = TempData["Dane1"];
            ViewBag.Dane2 = TempData["Dane2"];

            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Kontroler/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Kontroler/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Kontroler/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Kontroler/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Kontroler/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Kontroler/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
