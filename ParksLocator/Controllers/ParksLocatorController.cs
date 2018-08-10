using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksLocator.Services.Interfaces;
using ParksLocator.Services.Models.Request;

namespace ParksLocator.Controllers
{
    [Route("api/[controller]")]
    public class ParksLocatorController : Controller
    {
        private readonly IParksLocatorService _parksLocatorService;

        public ParksLocatorController(IParksLocatorService parksLocatorService)
        {
            _parksLocatorService = parksLocatorService;
        }

        [HttpGet]
        public async Task<ActionResult> ParksLocator(ParksServiceRequest parksServiceRequest)
        {
            try
            {
                var parks = await _parksLocatorService.GetNearestParksAsync(parksServiceRequest);

                return Ok(parks);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return BadRequest(message);
            }
        }
    }
}