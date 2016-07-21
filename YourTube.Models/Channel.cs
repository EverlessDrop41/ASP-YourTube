using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTube.Models
{
    public class Channel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Motto { get; set; }
        public Theme CurrentTheme { get; set; }
        public YourTubeUser ManagingUser { get; set; }

        #region SocialMediLainks
        public string YoutubeChannelId { get; set; }
        public string TwitterHandle { get; set; }
        public string InstagramUsername { get; set; }
        public string SnapchantName { get; set; }
        public string TumblrName { get; set; }
        public string GooglePlusName { get; set; }
        public string PatreonPage { get; set; }
        public string MerchStoreURL { get; set; }
        #endregion
    }
}
