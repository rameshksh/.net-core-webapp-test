using FitnessTestApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessTestApp.Services.Concrete
{
    public class AthleteService : IAthleteService
    {
        public List<Athlete> athletes;

        public AthleteService()
        {
            athletes = new List<Athlete>();
            athletes.Add(new Athlete { AthleteId = 1, Name = "John Deo", Level=0,ShuttleLevel=0 });
            athletes.Add(new Athlete { AthleteId = 2, Name = "Alex Cary", Level = 0, ShuttleLevel = 0 });
            athletes.Add(new Athlete { AthleteId = 3, Name = "Mark Cristane", Level = 0, ShuttleLevel = 0 });
            athletes.Add(new Athlete { AthleteId = 4, Name = "Vin Antony", Level = 0, ShuttleLevel = 0 });
        }
        public Athlete Get(int id)
        {
            return athletes.FirstOrDefault<Athlete>(a => a.AthleteId == id);
        }

        public List<Athlete> GetAll()
        {
            return athletes;
        }

        public void updateProgress(string query)
        {
            var athleteProgress = query.Split(':');
            foreach(var progress in athleteProgress)
            {
                if (progress != null && progress != string.Empty)
                {
                    var athleteObj = progress.Split('%');
                    var _athlete = Get(Int32.Parse(athleteObj[0]));
                    _athlete.Level = Int32.Parse(athleteObj[1]);
                    _athlete.ShuttleLevel = Int32.Parse(athleteObj[2]);
                }
            }
        }
    }
}
