using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LanZhouBeefNoodles.controllers
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        public IList<string> Index()
        {
            return new List<string> { "龚东海", "龚西海", "龚南海", "龚北海" };
        }
    }
}
