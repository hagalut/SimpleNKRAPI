using BookService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookService.Controllers
{
    

    public class TracksController : ApiController
    {
        // http://lyt.kristennetradio.dk:8000/;
        /*
        private static Track track = new Track()
        {
            id = 0,
            title = "Kristen Net Radio",
            album = "mere end bare musik",
            artist = "KNR",
            genre = "netradio",
            source = "http://listen.christianrock.net/stream/1/;",
            image = "http://kristennetradio.dk/SBC/samHTMweb/pictures/netradio.jpeg",
            trackNumber = 1,
            totalTrackCount = 1,
            duration = 0,
            site = "http://listen.christianrock.net/stream/1/;",
        };
        */
        private Track.TrackCollection Tracks = new Track.TrackCollection()
        {
            Tracks = new List<Track>()
            {
                new Track()
                {
                    id = 2,
                    title = "Kristen Net Radio",
                    album = "mere end bare musik",
                    artist = "KNR",
                    genre = "netradio",
                    source = "http://lyt.kristennetradio.dk:8000/;",
                    image = "http://kristennetradio.dk/SBC/samHTMweb/pictures/netradio.jpeg",
                    trackNumber = 1,
                    totalTrackCount = 1,
                    duration = 0,
                    site = "http://listen.christianrock.net/stream/1/;",
                },
                new Track()
                {
                    id = 3,
                    title = "Christian Rock",
                    album = "Today's Christian Rock",
                    artist = "Various",
                    genre = "netradio",
                    source = "http://listen.christianrock.net/stream/1/;",
                    image = "http://kristennetradio.dk/SBC/samHTMweb/pictures/netradio.jpeg",
                    trackNumber = 1,
                    totalTrackCount = 1,
                    duration = 0,
                    site = "http://listen.christianrock.net/stream/1/;",
                },
                new Track()
                {
                    id = 4,
                    title = "Christian Powerpraise",
                    album = "Praise & Worship with an edge",
                    artist = "Various",
                    genre = "netradio",
                    source = "http://listen.christianpowerpraise.net/stream/7/;",
                    image = "http://kristennetradio.dk/SBC/samHTMweb/pictures/netradio.jpeg",
                    trackNumber = 1,
                    totalTrackCount = 1,
                    duration = 0,
                    site = "http://listen.christianpowerpraise.net/stream/7/;",
                }
            }
        };

        // GET api/tracks
        public Track.TrackCollection Get()
        {
            return Tracks;
        }

        // GET api/tracks/5
        public string Get(int id)
        {
            return "track";
        }

        // POST api/tracks
        public string Post([FromBody]string track)
        {
            return track + " <--That??  nope! Dream on....";
        }

        // PUT api/tracks/5
        public string Put(int id, [FromBody]string track)
        {
            return track + "don't like this: "+ track + " pute pute! ;-)";
        }

        // DELETE api/tracks/5
        public string Delete(int id)
        {
            return "easy...No deleting ;-)";
        }
    }
}
