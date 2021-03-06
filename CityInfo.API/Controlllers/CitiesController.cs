﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controlllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            var temp = new JsonResult(CitiesDataStore.Current.Cities);
            temp.StatusCode = 200;
            return temp;
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);

        }
    }
}
