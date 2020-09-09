using AutoMapper;
using Lunitor.MediaServerMonitor.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunitor.MediaServerMonitor.Server.Endpoints.Sessions
{
    [Route("[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public SessionsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SessionDto>>> GetAllSessionsAsync()
        {
            var request = new GetAllSessionsRequest();

            var response = await _mediator.Send(request);

            return Ok(response.Select(s => _mapper.Map<SessionDto>(s)));
        }
    }
}
