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

        [HttpGet]
        public ActionResult GetCarMaintainces(DataSourceLoadOptions loadOptions)
        {
            var result = carMaintainceService.GetEntities(loadOptions);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarMaintaince([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await carMaintainceService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        [HttpPost]
        public async Task<ActionResult<CarMaintainceDto>> PostCarMaintainces([FromForm] string values)
        {
            await carMaintainceService.PostEntities(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarMaintainceDto>> DeleteCarMaintaince(int id)
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
