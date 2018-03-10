using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab4WebApplication.Data.Entities;
using Lab4WebApplication.Data;

namespace PetApi.Controllers
{
    public class PetController : ApiController
    {
        [RoutePrefix("api/pets")]
        public class PetsController : ApiController
        {
            private AppDbContext _dbContext;

            public PetsController()
            {
                _dbContext = new AppDbContext();
            }

            [HttpGet]
            public IEnumerable<Pet> GetAllPets()
            {
                return _dbContext.Pets.ToList();
            }

            [Route("{id}")]
            [HttpGet]
            public IHttpActionResult GetPet(int id)
            {
                var pet = _dbContext.Pets.FirstOrDefault((p) => p.Id == id);
                if (pet == null)
                {
                    return NotFound();
                }
                return Ok(pet);
            }
        }
    }
}