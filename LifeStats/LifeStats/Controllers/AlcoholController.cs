using LifeStats.Data;
using LifeStats.Models.Domain;
using LifeStats.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {
        private readonly AlcoDbContext dbContext;

        public AlcoholController(AlcoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // Get Data From Database - Domain models
            var drinks = dbContext.Alcohol.ToList();

            // Map domain Models to DTOs
            var drinksDto = new List<AlcoholDto>();
            foreach (var drink in drinks)
            {
                drinksDto.Add(new AlcoholDto()
                {
                    Id = drink.Id,
                    Name = drink.Name,
                    Percentage = drink.Percentage,
                    AmountMl = drink.AmountMl,
                    DateTime = drink.DateTime,
                });
            }

            //Return DTOs

            return Ok(drinksDto );
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddRecordAcloholDto addRecordAcloholDto )
        {
            // Map or Covert DTO to Domain Model
            var drink = new Alcohol
            {
                Name = addRecordAcloholDto.Name,
                Percentage = addRecordAcloholDto.Percentage,
                AmountMl = addRecordAcloholDto.AmountMl,
                DateTime = addRecordAcloholDto.DateTime,
            };
            dbContext.Alcohol.Add(drink);
            dbContext.SaveChanges();

            // Map Domain model back to DTO

            var drinkDto = new AlcoholDto
            {
                Id = drink.Id,
                Name = drink.Name,
                Percentage = drink.Percentage,
                AmountMl = drink.AmountMl,
                DateTime = drink.DateTime,
            };

            return CreatedAtAction(nameof(GetAll), new { id = drink.Id}, drinkDto) ;
            // Use domain Model to create record
        }

    }
}
