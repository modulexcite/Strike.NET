#region

using System;
using Newtonsoft.Json;

#endregion

namespace StrikeNET.V2
{
    /// <summary>
    ///     Reprents a torrent search result.
    /// </summary>
    public interface ITorrentSearchInfo
    {
        /// <summary>
        ///     The dedicated Strike page for the torrent.
        /// </summary>
        [JsonProperty("page")]
        Uri Page { get; }

        /// <summary>
        ///     The torrent magnet Uri.
        /// </summary>
        [JsonProperty("magnet_uri")]
        Uri MagnetUri { get; }

        /// <summary>
        ///     The dedicated RSS feed for the torrent.
        /// </summary>
        [JsonProperty("rss_feed")]
        Uri RssFeed { get; }

        /// <summary>
        ///     The total number of torrent downloads.
        /// </summary>
        [JsonProperty("download_count")]
        int DownloadCount { get; }
    }
}