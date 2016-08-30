using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class Track
    {
        public class TrackCollection
        {
            public List<Track> Tracks { get; set; }
        }
        public int id { get; set; }
        public string title { get; set; }
        public string album { get; set; }
        public string artist { get; set; }
        public string genre { get; set; }
        public string source { get; set; }
        public string image { get; set; }
        public int trackNumber { get; set; }
        public int totalTrackCount { get; set; }
        public int duration { get; set; }
        public string site { get; set; }
    }
}