using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelopia.Assignment.Entity.Models;

namespace Travelopia.Assignment.Data.IRepository
{
    public interface ITravelSurveyRepository
    {
        List<TravelSurveyDetails> GetAllGetAllTravelSurveyDetails();
        void AddTravelSurveyDetails(TravelSurveyDetails travelSurveyDetails);
    }
}
