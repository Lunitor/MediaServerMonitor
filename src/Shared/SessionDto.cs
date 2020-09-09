namespace Lunitor.MediaServerMonitor.Shared
{
    public class SessionDto
    {
        public string UserName { get; set; }
        public string Client { get; set; }
        public string DeviceName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdminOrService { get; set; }
        public bool NowPlaying { get; set; }
        public string NowPlayingItemName { get; set; }
    }
}
