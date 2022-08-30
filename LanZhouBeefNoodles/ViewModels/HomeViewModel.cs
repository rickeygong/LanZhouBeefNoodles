﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouBeefNoodles.Models;

namespace LanZhouBeefNoodles.ViewModels
{
    public class HomeViewModel
    {
        public IList<Noodle> Noodles { get; set; }
        public IList<Feedback> Feedbacks { get; set; }
    }
}
