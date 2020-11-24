using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTestApp.Models
{
    public class Athlete
    {
        public int AthleteId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ShuttleLevel { get; set; }
    }
}
