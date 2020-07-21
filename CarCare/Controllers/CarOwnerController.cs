using CarCare.Application.Services;
using CarCare.Application.Services.Dtos;
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
    public class CarOwnerController : ControllerBase
    {
        private readonly ICarOwnerService carOwnerService;
        public CarOwnerController(ICarOwnerService carOwnerService)
        {
            this.carOwnerService = carOwnerService;
        }

        [HttpGet]
        public ActionResult GetCarMaintainces(DataSourceLoadOptions loadOptions)
        {
            var result = carOwnerService.GetEntities(loadOptions);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarMaintaince([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await carOwnerService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        [HttpPost]
        public async Task<ActionResult<CarOwnerDto>> PostCarMaintainces([FromForm] string values)
        {
            await carOwnerService.PostEntities(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarOwnerDto>> DeleteCarMaintaince(int id)
        {
            var color = await carOwnerService.DeleteEntity(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
