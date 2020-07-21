using CarCare.Application.Services.CarMaintainceService;
using CarCare.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCare.Application.Services.CarMaintainceService.Dtos;

namespace CarCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarMaintainceController : ControllerBase
    {
        private readonly ICarMaintainceService carMaintainceService;
        public CarMaintainceController(ICarMaintainceService carMaintainceService)
        {
            this.carMaintainceService = carMaintainceService;
        }

        // GET: api/Car
        [HttpGet]
        public ActionResult GetCars(DataSourceLoadOptions loadOptions)
        {
            var result = carMaintainceService.GetEntities(loadOptions);
            return Ok(result);
        }

        // PUT: api/Car/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await carMaintainceService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        // POST: api/Car
        [HttpPost]
        public async Task<ActionResult<CarMaintainceDto>> PostCars([FromForm] string values)
        {
            await carMaintainceService.PostEntities(values);
            return Ok();
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CarMaintainceDto>> DeleteCar(int id)
        {
            var color = await carMaintainceService.DeleteEntity(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
