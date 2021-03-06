﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using MovieAngularJSApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieAngularJSApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
		// GET: api/movies
		[HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new List<Movie> {
                new Movie {Id=1, Title="Star Wars", Director="Lucas"},
                new Movie {Id=2, Title="King Kong", Director="Jackson"},
                new Movie {Id=3, Title="Memento", Director="Nolan"}
            };
        }

		// GET api/movies/5
		[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

		// POST api/movies
		[HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/movies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

		// DELETE api/movies/5
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
