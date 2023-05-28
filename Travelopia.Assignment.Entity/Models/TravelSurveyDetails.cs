using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Travelopia.Assignment.Entity.Models
{
    public class TravelSurveyDetails
    {
        [Key]
        [JsonProperty(PropertyName = "id")]

        public string Id { get; set; }
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty(PropertyName = "travelPlace")]
        public string TravelPlace { get; set; }

        [JsonProperty(PropertyName = "numberOfTravelers")]
        public int NumberOfTravelers { get; set; }

        [JsonProperty(PropertyName = "budgetPerPersonInDollar")]
        public double BudgetPerPersonInDollar { get; set; }
    }
}
