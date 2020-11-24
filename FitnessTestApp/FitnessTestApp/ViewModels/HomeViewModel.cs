using FitnessTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTestApp.ViewModels
{
    public class HomeViewModel
    {
        public Dictionary<String, FitnessScore> FitnessScore { get; set; }
        public List<Athlete> Athletes { get; set; }
    }
}
