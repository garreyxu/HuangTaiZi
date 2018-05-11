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
        HuangTaiZiDb _db = new HuangTaiZiDb();

        public ActionResult Index([Bind(Prefix = "id")] int memberId)
        {
            var member = _db.Members.Find(memberId);
            if (member != null)
            {
                return View(member);
            }
            return HttpNotFound();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
