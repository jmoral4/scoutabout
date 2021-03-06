﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LocationController : Controller
    {
        //
        // GET: /Location/

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult SearchCities(string CitySearch)
        {
            List<Web.Models.Location> locations = new List<Models.Location>();
            locations.Add(new Models.Location() { City = "San Francisco", Image = Url.Content(@"..\Images\Sanfran.png"), State = "CA", Summary = "Home of the Golden Gate bridge and south of the Red Wood Forest. Oldest Chinatown in the US, classic city parks and fresh made sourdough bread.", Zipcode = "96789" });
            locations.Add(new Models.Location() { City = "Portland", Image = Url.Content(@"..\Images\Portland.png"), State = "OR", Summary = "Home of the Golden Gate bridge and south of the Red Wood Forest. Oldest Chinatown in the US, classic city parks and fresh made sourdough bread.", Zipcode = "96789" });
            locations.Add(new Models.Location() { City = "Chicago", Image = Url.Content(@"..\Images\Chicago.png"), State = "IL", Summary = "Home of the Golden Gate bridge and south of the Red Wood Forest. Oldest Chinatown in the US, classic city parks and fresh made sourdough bread.", Zipcode = "96789" });
            locations.Add(new Models.Location() { City = "Baltimore", Image = Url.Content(@"..\Images\Natty-boh.png"),State = "MD",Summary= "Baltimore-it's not so much a place as an experience. And after close to three hundred years of history, this city can deliver more fun-filled family days (and romantic evenings) to make any vacation one you’ll remember forever."});
            
            if (!String.IsNullOrEmpty(CitySearch))
            {
                var results = locations.Where(x => x.City.ToUpperInvariant().Contains(CitySearch.ToUpperInvariant()));

                return PartialView("Partials/LocationPartial", results);
            }
            else
            {
                var results = locations.Take(5);

                return PartialView("Partials/LocationPartial", results);
            }
        }
    }
}
