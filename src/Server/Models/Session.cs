using System.Collections.Generic;

namespace Lunitor.MediaServerMonitor.Server.Models
{
    public class Session
    {
        private static List<string> AdminUserNames = new List<string>
            {
                "Luna",
                "Admin",
                "Administrator",
                ""
            };

        public string UserName { get; set; }
        public string Client { get; set; }
        public string DeviceName { get; set; }
        public bool IsActive { get; set; }
        public bool NowPlaying => NowPlayingItem != null;
        public NowPlayingItem NowPlayingItem { get; set; }

        public bool IsNotAdmin
        {
            get {
                if (UserName == null)
                    return false;

                foreach (var adminUserName in AdminUserNames)
                {
                    if (adminUserName.ToUpper() == UserName.ToUpper())
                        return false;
                }

                return true;
            }
        }
    }
}