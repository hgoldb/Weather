using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class WeatherController : BaseApiController
    {
        private readonly DataContext _context;
        public WeatherController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Weather>> GetWeather(Guid id)
        {
            return await _context.WeatherTable.FindAsync();
        }
    }
}