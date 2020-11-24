using System;
using System.Collections.Generic;
using FitnessTestApp.Models;

namespace FitnessTestApp.Services
{
    interface IFitnessScoreService
    {
        public Dictionary<String, FitnessScore> GetAll();
    }
}
