using Huangtaizi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Huangtaizi.Controllers
{
    public class HomeController : Controller
    {
        HuangTaiZiDb _db = new HuangTaiZiDb();

        public ActionResult Index(string SearchTerm = null)
        {
            var model =
                _db.Members
                    .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                    .Where(r => SearchTerm == null || r.FirstName.StartsWith(SearchTerm))
                    .Take(10)
                    .Select(r => new MemberListViewModel
                    {
                        Id = r.Id,
                        Name = r.FirstName + " " + r.LastName,
                        State = r.State,
                        City = r.City,
                        School = r.School,
                        CountOfReviews = r.Reviews.Count()
                    });

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Garrey";
            model.Location = "California, USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}