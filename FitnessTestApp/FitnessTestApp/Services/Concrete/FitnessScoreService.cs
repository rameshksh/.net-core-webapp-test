using FitnessTestApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace FitnessTestApp.Services.Concrete
{   
    public class FitnessScoreService : IFitnessScoreService
    {
        public Dictionary<String, FitnessScore> GetAll()
        {
            var jsonString = File.ReadAllText(".\\App_Data\\fitnessScore_beeptest.json");
            var fitnessScore = JsonSerializer.Deserialize<FitnessScore[]>(jsonString);
            Dictionary<String, FitnessScore> fitnessScoreDictionary = new Dictionary<String, FitnessScore>();
            foreach (FitnessScore _fitnessScore in fitnessScore)
                fitnessScoreDictionary.Add(_fitnessScore.StartTime, _fitnessScore);
            return fitnessScoreDictionary;
        }
    }
}
