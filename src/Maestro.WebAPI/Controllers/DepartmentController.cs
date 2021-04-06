using Maestro.Core.Features.DepartmentFeature.Command.AddDepartment;
using Maestro.Core.Features.DepartmentFeature.Queries.GetAllDepartment;
using Maestro.Core.Features.DepartmentFeature.Queries.GetDepartmetById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maestro.WebAPI.Controllers
{

    public class DepartmentController : ApiBaseController
    {
        [HttpGet("{departmentId}")]
        public async Task<IActionResult> Get(int departmentId)
        {
            return Ok(await Mediator.Send(new GetDepartmentByIdQuery { DepartmentId = departmentId }));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            return Ok(await Mediator.Send(new GetAllDepartmentQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(AddDepartmentCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //[HttpPut]
        //public async Task<IActionResult> UpdateDepartment()
        //{ 
        
        //}


    }
}
