using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace highchart_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LineChartBasic()
        {
             return View();
        }

        public ActionResult PieChart()
        {
            ViewBag.Message = "PieChart.";

            return View();
        }
    }
}