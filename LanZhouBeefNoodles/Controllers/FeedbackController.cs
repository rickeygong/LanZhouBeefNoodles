using LanZhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanZhouBeefNoodles.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackRepository _feedbackRepository;
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                return RedirectToAction("FeebackComplete");
            }
            return View();

        }
        public IActionResult FeebackComplete()
        {
            return View();
        }
    }
}
