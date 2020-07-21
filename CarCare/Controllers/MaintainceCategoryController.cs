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
    public class MaintainceCategoryController : ControllerBase
    {
        private readonly IMaintainceCategoryService MaintainceCategoryService;
        public MaintainceCategoryController(IMaintainceCategoryService MaintainceCategoryService)
        {
            this.MaintainceCategoryService = MaintainceCategoryService;
        }

        [HttpGet]
        public ActionResult GetMaintainceCategorys(DataSourceLoadOptions loadOptions)
        {
            var result = MaintainceCategoryService.GetEntities(loadOptions);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaintainceCategory([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await MaintainceCategoryService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        [HttpPost]
        public async Task<ActionResult<MaintainceCategoryDto>> PostCarModels([FromForm] string values)
        {
            await MaintainceCategoryService.PostEntities(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MaintainceCategoryDto>> DeleteCarModel(int id)
        {
            var color = await MaintainceCategoryService.DeleteEntity(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
