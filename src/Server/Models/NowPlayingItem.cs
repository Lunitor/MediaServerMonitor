namespace Lunitor.MediaServerMonitor.Server.Models
{
    public class NowPlayingItem
    {
        public string Name { get; set; }
        public bool IsSeries => SeriesName != null;
        public string SeriesName { get; set; }
    }
}