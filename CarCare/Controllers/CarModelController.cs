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
    public class CarModelController : ControllerBase
    {
        private readonly ICarModelService carModelService;
        public CarModelController(ICarModelService carModelService)
        {
            this.carModelService = carModelService;
        }

        [HttpGet]
        public ActionResult GetCarModels(DataSourceLoadOptions loadOptions)
        {
            var result = carModelService.GetEntities(loadOptions);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarModel([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await carModelService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        [HttpPost]
        public async Task<ActionResult<CarModelDto>> PostCarModels([FromForm] string values)
        {
            await carModelService.PostEntities(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarModelDto>> DeleteCarModel(int id)
        {
            var color = await carModelService.DeleteEntity(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
