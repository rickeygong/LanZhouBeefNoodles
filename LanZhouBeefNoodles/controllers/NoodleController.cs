using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LanZhouBeefNoodles.controllers
{
    public class NoodleController : Controller
    {
        public IList<string> Index()
        {
            return new List<string> { "牛肉面", "羊肉面", "西红柿鸡蛋面", "刀削面" };
        }
    }
}
