using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;

namespace API.Controllers
{
    public class CitiesController : BaseApiController
    {
        private readonly ICityService _service;
        private readonly ILogger _logger;

        public CitiesController(ICityService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }
        
        // GET api/cities
        [HttpGet]
        public async Task<ActionResult<City>> Get()
        {
            var city = await _service.GetLastAccessedCityAsync();
            return city;
        }

        [HttpPost]
        public async Task Post([FromBody] City city)
        {
            await _service.UpdateLastAccessedCityAsync(city);
        }

    }
}