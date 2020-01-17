using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using VidlyASP.Dtos;
using VidlyASP.Models;

namespace VidlyASP.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //POST /api/rental
        [System.Web.Http.HttpPost]
        public IHttpActionResult Rent(NewRentalDto dto)
        {
            if (dto.MovieIds.Count == 0) return BadRequest("No Movie Id is supplied");


            var customer = _context.Customers.SingleOrDefault(c => c.Id == dto.CustomerId);
            if (customer == null) return BadRequest("customer Id is not valid");

            var movies = _context.Movies.Where(m => dto.MovieIds.Contains(m.Id));
            if (movies.Count() != dto.MovieIds.Count) return BadRequest("Invalid Movies in Request");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0) return BadRequest("Movie is not available");
                movie.NumberAvailable--;

                var rentalToAdd = new Rental()
                {
                    Customer = customer,
                    CustomerId = dto.CustomerId,
                    Movie = movie,
                    MovieId = movie.Id,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rentalToAdd);
            }
            _context.SaveChanges();

            return Ok();
        }


    }
}