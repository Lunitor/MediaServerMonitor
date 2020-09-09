using Lunitor.MediaServerMonitor.Server.Models;
using MediatR;
using System.Collections.Generic;

namespace Lunitor.MediaServerMonitor.Server.Endpoints.Sessions
{
    internal class GetAllSessionsRequest : IRequest<IEnumerable<Session>>
    { }
}
