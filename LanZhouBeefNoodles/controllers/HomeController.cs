using Microsoft.AspNetCore.Mvc;

namespace LanZhouBeefNoodles.controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Hello from home";
        }

        public string About()
        {
            return "Hello from about";
        }
    }
}
