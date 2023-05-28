using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelopia.Assignment.Entity.Models;

namespace Travelopia.Assignment.Business.IServices
{
    public interface ITravelSurveyService
    { 
        public List<TravelSurveyDetails> GetAllTravelSurveyDetails();

        public void AddTravelSurveyDetails(TravelSurveyDetails travelSurveyDetails);
    }
}
