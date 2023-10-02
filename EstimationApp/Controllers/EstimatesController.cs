using Microsoft.AspNetCore.Mvc;
using EstimationApp.Services;

namespace EstimationApp.Controllers
{
    [Route("api/estimates")]
    [ApiController]
    public class EstimatesController : ControllerBase
    {
        private readonly EstimateService _estimateService;

        public EstimatesController(EstimateService estimateService)
        {
            _estimateService = estimateService;
        }

        [HttpGet]
        public IActionResult GetAllEstimates()
        {
            var estimates = _estimateService.GetAllEstimates();
            return Ok(estimates);
        }

        [HttpGet("{id}")]
        public IActionResult GetEstimateById(int id)
        {
            var estimate = _estimateService.GetEstimateById(id);
            if (estimate == null)
            {
                return NotFound();
            }
            return Ok(estimate);
        }

        [HttpPost]
        public IActionResult CreateEstimate(Estimate estimate)
        {
            _estimateService.CreateEstimate(estimate);
            return CreatedAtAction(nameof(GetEstimateById), new { id = estimate.Id }, estimate);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEstimate(int id, Estimate estimate)
        {
            if (id != estimate.Id)
            {
                return BadRequest();
            }

            _estimateService.UpdateEstimate(estimate);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEstimate(int id)
        {
            _estimateService.DeleteEstimate(id);
            return NoContent();
        }

        [HttpGet("calculate-three-points")]
        public IActionResult CalculateThreePoints(int estimateId)
        {
            try
            {
                var result = _estimateService.CalculateThreePointsEstimate(estimateId);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
