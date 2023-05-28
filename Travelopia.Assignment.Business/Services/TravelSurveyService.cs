using Travelopia.Assignment.Business.IServices;
using Travelopia.Assignment.Data.IRepository;
using Travelopia.Assignment.Entity.Models;

namespace Travelopia.Assignment.Business.Services
{
    public class TravelSurveyService : ITravelSurveyService
    {
        private readonly ITravelSurveyRepository _travelSurveyRepository;
        public TravelSurveyService(ITravelSurveyRepository travelSurveyRepository)
        {
            _travelSurveyRepository = travelSurveyRepository;
        }

        public void AddTravelSurveyDetails(TravelSurveyDetails travelSurveyDetails)
        {
            _travelSurveyRepository.AddTravelSurveyDetails(travelSurveyDetails);
        }

        public List<TravelSurveyDetails> GetAllTravelSurveyDetails()
        {
            return _travelSurveyRepository.GetAllGetAllTravelSurveyDetails();
        }
    }
}
