using Huangtaizi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Huangtaizi.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Review
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.Name
                select r;

            return View(model);
        }

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Review/Create
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

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);

            return View(review);
        }

        // POST: Review/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            return View(review);
        }

        // GET: Review/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Review/Delete/5
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

        static List<MemberReview> _reviews = new List<MemberReview>
        {
            new MemberReview {
                Id = 1,
                Name = "Garrey",
                Rating = 2.1,
                Comment = "Hehe.",
            },
            new MemberReview {
                Id = 2,
                Name = "LiuYi",
                Rating = 6.8,
                Comment = "Perpetual motive machine like Paul Scholes. ",
            },
            new MemberReview {
                Id = 3,
                Name = "Nick",
                Rating = 6.5,
                Comment = "Run like jaguar.",
            },
            new MemberReview {
                Id = 4,
                Name = "Ben",
                Rating = 6.9,
                Comment = "Ghost assister",
            }
        };
    }
}
