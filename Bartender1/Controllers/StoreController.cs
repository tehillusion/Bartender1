using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bartender1.Models;

namespace Bartender1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store/
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
            new Genre { Name = "Cognac"},
            new Genre { Name = "Taquila"},
            new Genre { Name = "Whiskey"},
            new Genre { Name = "Bourbon"}
            };
            return View(genres);
        }


        // GET: Store/Browse?type=Cognac
        public ActionResult Browse(string genre)
        {
            var genreModel = new Models.Genre { Name = genre };
            return View(genreModel);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            var drink = new Drink { Title = "Drink " + id };
            return View(drink);
        }
    }
}   