using CarCare.Application.Services.CarService;
using CarCare.Application.Services.CarService.Dto;
using CarCare.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // GET: api/Car
        [HttpGet]
        public ActionResult GetCars(DataSourceLoadOptions loadOptions)
        {
            var result = carService.GetEntities(loadOptions);
            return Ok(result);
        }

        // PUT: api/Car/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await carService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        // POST: api/Car
        [HttpPost]
        public async Task<ActionResult<CarDto>> PostCars([FromForm] string values)
        {
            await carService.PostEntities(values);
            return Ok();
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CarDto>> DeleteCar(int id)
        {
            var color = await carService.DeleteEntity(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
