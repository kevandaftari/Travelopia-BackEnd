using EFCoreInMemoryDbDemo;
using Travelopia.Assignment.Data.IRepository;
using Travelopia.Assignment.Entity.Models;

namespace Travelopia.Assignment.Data.Repository
{
    public class TravelSurveyRepository : ITravelSurveyRepository
    {
        public void AddTravelSurveyDetails(TravelSurveyDetails travelSurveyDetails)
        {
            using (var context = new ApiDbContext())
            {
                travelSurveyDetails.Id = Guid.NewGuid().ToString();
                context.TravelSurveys.Add(travelSurveyDetails);
                context.SaveChanges();
            }
        }

        public List<TravelSurveyDetails> GetAllGetAllTravelSurveyDetails()
        {
            using (var context = new ApiDbContext())
            {
                return context.TravelSurveys.ToList();
            }
        }
    }
}
