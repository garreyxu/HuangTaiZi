using Huangtaizi.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Huangtaizi.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        //[Authorize]
        [Log]
        public ActionResult Search(string name = "Huangtaizi")
        {
            throw new Exception("Error");
            var message = Server.HtmlEncode(name);
            return Content(message);
        }

    }
}