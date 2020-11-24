using FitnessTestApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTestApp.Services
{
    public interface IAthleteService 
    {
        public List<Athlete> GetAll();
        public Athlete Get(int id);
        public void updateProgress(string query);
    }
}