using Microsoft.AspNetCore.Mvc;

namespace LanZhouBeefNoodles.controllers
{
    [Controller]
    public class Test : Controller
    {
        public ActionResult Index()
        {
            return Content("Hello from test index");
        }

        public string About()
        {
            return "Hello from test about";
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
