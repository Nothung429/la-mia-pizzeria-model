using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_model.Models;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        // GET: PizzaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            List<Pizza> ListPizza = new List<Pizza>();

            ListPizza.Add(new Pizza("Pizza Margherita", "bona come er pane", "cane.png", 3.99));
            ListPizza.Add(new Pizza("Pizza Capricciosa", "idem co patate", "cane.png", 7.99));
            ListPizza.Add(new Pizza("Pizza Diavola", "er duca", "cane.png", 12.99));
            ListPizza.Add(new Pizza("Pizza Quattro Formaggi", "fiocina", "cane.png", 9.99));
            ListPizza.Add(new Pizza("Pizza Coi Funghi", "er monnezza", "cane.png", 11.99));
            ListPizza.Add(new Pizza("Pizza Salsiccia e Salame", "tonino u lurdu", "cane.png", 5.99));

            return View(ListPizza[id]);
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
