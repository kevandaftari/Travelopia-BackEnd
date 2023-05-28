
using Microsoft.AspNetCore.Mvc;
using Travelopia.Assignment.Business.IServices;
using Travelopia.Assignment.Entity.Models;

namespace Travelopia_Assignment.Controllers
{
    public class TravelSurveyController : ControllerBase
    {
        private readonly ITravelSurveyService _travelSurveyService;
        private readonly ILogger<TravelSurveyController> _logger;

        public TravelSurveyController(
            ITravelSurveyService travelSurveyService,
            ILogger<TravelSurveyController> logger
            ) : base()
        {
            _travelSurveyService = travelSurveyService;
            _logger = logger;
        }


        [HttpGet("[action]")]
        public IActionResult GetAllTravelSurveyDetails()
        {
            try
            {
                var travelSurveyDetails = _travelSurveyService.GetAllTravelSurveyDetails();
                if (travelSurveyDetails == null)
                    return NoContent();
                return Ok(travelSurveyDetails);
            }
            catch(Exception ex)
            {
                _logger.LogError("error occured in GetAllTravelSurveyDetails:{Message}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("[action]")]
        public IActionResult AddTravelSurveyDetails([FromBody]TravelSurveyDetails travelSurveyDetails)
        {
            try
            {
                if(travelSurveyDetails == null)
                {
                    return BadRequest();
                }
                _travelSurveyService.AddTravelSurveyDetails(travelSurveyDetails);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("error occured in AddTravelSurveyDetails:{Message}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
