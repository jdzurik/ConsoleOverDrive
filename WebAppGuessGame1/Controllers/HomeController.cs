using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppGuessGame1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var rand = new Random();

            HttpCookie RandNum = new HttpCookie("RandNum");
            RandNum.Value = rand.Next(1, 101).ToString();
            RandNum.Expires = DateTime.Now.AddHours(1);
            Response.Cookies["RandNum"].Value = rand.Next(1, 101).ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Guess(int guess)
        {
            string strSuccessMessage = "";
            int randNum = Convert.ToInt32(Request.Cookies["RandNum"].Value.ToString());

            if (guess < randNum)
                strSuccessMessage = "Your guess is Lower";

            if (guess == randNum)
                strSuccessMessage = "Congratulations! Your guess is correct";

            if (guess > randNum)
                strSuccessMessage = "Your guess is higher"; 

            return Content(strSuccessMessage);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}