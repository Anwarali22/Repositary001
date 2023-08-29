using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using projectCRUD.Models.Commands;

using projectCRUD.Models.Query;
using System.Threading.Tasks;

namespace projectCRUD.Controllers
{
    public class StudentDetailscontroller : Controller
    {
        private IMediator Mediator;
        private ILogger<StudentDetailscontroller> _logger;
        public StudentDetailscontroller(IMediator mediator, ILogger<StudentDetailscontroller> logger)
        {
            Mediator = mediator;
            this._logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetstudentDetails()
        {
            return Ok(await Mediator.Send(new GetstudentDetails()));
        }


        [HttpGet]
        public async Task<IActionResult> GetstudentdetailsbyID(int id)
        {
            return Ok(await Mediator.Send(new GetstudentdetailsbyID { ID = id }));
        }

        [HttpPost]

        public async Task<IActionResult> CreateStudentDetails([FromBody] createstudentDetails command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> deletestudentdetails(int id)

        {
            return Ok(await Mediator.Send(new DeleteStudentDetails { Id = id }));
        }


        [HttpPost]
        public async Task<IActionResult> UpdateStudentDetails(int id, [FromBody] UpdateStudentDetails command)
        {
            command.Id = id;
            return Ok(await Mediator.Send(command));
        }
    }
}
