using Democracy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Democracy.Controllers
{
    public class StatesController : Controller
    {
        /// <summary>
        /// The data base connection
        /// </summary>
        private DemocracyContext db = new DemocracyContext();

        /// <summary>
        /// List all states
        /// </summary>
        /// <returns>The view</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.States.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Creates a new state
        /// </summary>
        /// <param name="state">The state</param>
        /// <returns>The view</returns>
        [HttpPost]
        public ActionResult Create(State state)
        {
            if (!ModelState.IsValid)
            {
                return View(state);
            }

            db.States.Add(state);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            
            base.Dispose(disposing);
        }
	}
}