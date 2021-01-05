using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcControllerScaffHold.Controllers
{
    public class HomeController : Controller
    {
        public static List<Models.kitap> kitap = new List<Models.kitap> ();

        

        // GET: Home
        public ActionResult Index()
        {
            //Create();
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            Models.kitap kisi = new Models.kitap();
            Models.kitap kisi2 = new Models.kitap();
            Models.kitap kisi3 = new Models.kitap();

            kisi.adi = "Mustafa Koca";
            kisi.sayfasayisi = 146;
            kisi.yayinevi = "Elpis";
            kisi.yazar = "Mustafa Koca";

            kisi2.adi = "mehmet ali";
            kisi2.sayfasayisi = 150;
            kisi2.yayinevi = "ithaki";
            kisi2.yazar = "hikmet anıl";

            kisi3.adi = "ali veli";
            kisi3.sayfasayisi = 250;
            kisi3.yayinevi = "mehmet";
            kisi3.yazar = "canan";

            kitap.Add(kisi);
            kitap.Add(kisi2);
            kitap.Add(kisi3);

            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
