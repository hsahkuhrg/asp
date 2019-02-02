using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP2.Controllers
{
    public class HomeController : Controller
    {
        static List<ASP2.Models.Respons> respons = new List<Models.Respons>();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            respons.Add(new Models.Respons() { Name = "EEEE", Date = System.DateTime.Today, Row = "Egejhbf ekhbtve hjgberg rnb bghutbg erhtb gthrbg rthgb rthg rhgr thirsefjerhg srkths " });
            IEnumerable<ASP2.Models.Respons> r = respons;
            return View(r);
        }

        [HttpPost]
        public ActionResult About(ASP2.Models.Respons respons1)
        {
            respons1.Date = System.DateTime.Today;
            respons.Add(respons1);

            IEnumerable<ASP2.Models.Respons> r = respons;
            return View(r);
        }

        
        public ActionResult Contact(string Name, string answer1 = "null", string answer2 = "null", string answer3 = "null", string answer4 = "null")
        {
            if(HttpContext.Request.HttpMethod.ToString() == "GET")
            {
                return View();
            }
            List<string> st = new List<string>() { Name, answer1, answer2, answer3, answer4 };

            return View("View1", st);
        }
    }
}