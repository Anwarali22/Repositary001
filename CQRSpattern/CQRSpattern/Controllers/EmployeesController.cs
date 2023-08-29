using CQRSpattern.Models.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CQRSpattern.Controllers
{
    public class EmployeesController : Controller
    {
        private IMediator mediator;

        public EmployeesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            return Ok(await mediator.Send(new GetPersonAlldetails()));
        }


    }
}
