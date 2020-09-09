using Lunitor.MediaServerMonitor.Server.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lunitor.MediaServerMonitor.Server.Endpoints.Sessions
{
    class GetAllSessionRequestHandler : IRequestHandler<GetAllSessionsRequest, IEnumerable<Session>>
    {
        private readonly IMediaServerApi _mediaServerApi;

        public GetAllSessionRequestHandler(IMediaServerApi mediaServerApi)
        {
            _mediaServerApi = mediaServerApi;
        }

        public Task<IEnumerable<Session>> Handle(GetAllSessionsRequest request, CancellationToken cancellationToken)
        {
            return _mediaServerApi.GetAllSessionsAsync();
        }
    }
}
