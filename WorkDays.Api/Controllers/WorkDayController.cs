using Microsoft.AspNetCore.Mvc;
using WorkDays.Core.Services.Interfaces;
using WorkDays.Domain.WorkDays;

namespace WorkDays.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkDayController : ControllerBase
    {
        private readonly ILogger<WorkDayController> _logger;
        private readonly IWorkDayService _service;

        public WorkDayController(ILogger<WorkDayController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult AddWorkDay([FromBody] WorkDay workDay)
        {
            _service.PostWorkDay(workDay);
            return Ok();
        }
    }
}
