using LanZhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;
using LanZhouBeefNoodles.ViewModels;
using System.Linq;

namespace LanZhouBeefNoodles.controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;

        public HomeController(INoodleRepository noodleRepository,IFeedbackRepository feedbackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }

        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList(),
            };
            return View(viewModel);
        }

        public string About()
        {
            return "Hello from about";
        }
    }
}
