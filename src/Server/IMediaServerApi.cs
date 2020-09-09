using Lunitor.MediaServerMonitor.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lunitor.MediaServerMonitor.Server
{
    interface IMediaServerApi
    {
        public Task<IEnumerable<Session>> GetAllSessionsAsync();
    }
}
