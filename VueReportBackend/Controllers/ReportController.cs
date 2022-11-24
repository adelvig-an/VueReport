using AutoMapper;
using BussinesLayer.Reports.Commands.CreateReport;
using BussinesLayer.Reports.Commands.DeleteReport;
using BussinesLayer.Reports.Commands.UpdateReport;
using BussinesLayer.Reports.Queries.GetReportDetails;
using BussinesLayer.Reports.Queries.GetReportList;
using Microsoft.AspNetCore.Mvc;
using VueReportBackend.Models;

namespace VueReportBackend.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : BaseController
    {
        private readonly IMapper _mapper;

        public ReportController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<ReportListVM>> GetAll()
        {
            var query = new GetReportListQuery
            {
                UserId = UserId,
            };
            
            var vm = await Mediator.Send(query);
            
            return Ok(vm);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ReportDetailsVM>> Get(Guid id)
        {
            var query = new GetReportDetailsQuery
            {
                UserId = UserId,
                Id = id,
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Greate([FromBody] CreateReportDto createReportDto)
        {
            var command = _mapper.Map<CreateReportCommand>(createReportDto);
            command.UserId = UserId;
            var reportId = await Mediator.Send(command);
            return Ok(reportId);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateReportDto updateReportDto)
        {
            var command = _mapper.Map<UpdateReportCommand>(updateReportDto);
            command.UserId = UserId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteReportCommand
            { 
                Id = id, 
                UserId = UserId
            };
            await Mediator.Send(command);
            return NoContent();

        }
    }
}
