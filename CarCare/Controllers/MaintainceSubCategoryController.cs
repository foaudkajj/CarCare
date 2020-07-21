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
    public class MaintainceSubCategoryController : ControllerBase
    {
        private readonly IMaintainceSubCategoryService MaintainceSubCategoryService;
        public MaintainceSubCategoryController(IMaintainceSubCategoryService MaintainceSubCategoryService)
        {
            this.MaintainceSubCategoryService = MaintainceSubCategoryService;
        }

        [HttpGet]
        public ActionResult GetMaintainceSubCategories(DataSourceLoadOptions loadOptions)
        {
            var result = MaintainceSubCategoryService.GetEntities(loadOptions);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaintainceSubCategory([FromForm] int key, [FromForm] string values)
        {
            var puttedBranch = await MaintainceSubCategoryService.PutEntity(key, values);

            return Ok(puttedBranch);
        }

        [HttpPost]
        public async Task<ActionResult<MaintainceSubCategoryDto>> PostCarModels([FromForm] string values)
        {
            await MaintainceSubCategoryService.PostEntities(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MaintainceSubCategoryDto>> DeleteCarModel(int id)
        {
            var color = await MaintainceSubCategoryService.DeleteEntity(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
