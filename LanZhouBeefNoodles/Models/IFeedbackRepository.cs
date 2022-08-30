using System.Collections.Generic;

namespace LanZhouBeefNoodles.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
    }
}
