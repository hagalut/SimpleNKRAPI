using BookService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookService.Controllers
{


    public class JacksController : ApiController
    {
        private Jack.JackCollection Jacks = new Jack.JackCollection()
        {
            Jacks = new List<Jack>()
            {
                new Jack()
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
                new Jack()
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
                new Jack()
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
        public Jack.JackCollection Get()
        {
            return Jacks;
        }

        // GET api/tracks/5
        public string Get(int id)
        {
            return "jack";
        }

        // POST api/tracks
        public Jack.JackCollection Post([FromBody] Jack jackObj)
        {

            Jacks.Jacks.Add(new Jack()
            {
                id = 4,
                title = jackObj.title,
                album = jackObj.album,
                artist = jackObj.artist,
                genre = jackObj.genre,
                source = "http://listen.christianpowerpraise.net/stream/7/;",
                image = "http://kristennetradio.dk/SBC/samHTMweb/pictures/netradio.jpeg",
                trackNumber = 1,
                totalTrackCount = 1,
                duration = 0,
                site = "http://listen.christianpowerpraise.net/stream/7/;",
            });

            return Jacks;
        }

        // PUT api/tracks/5
        public string Put(int id, [FromBody]string track)
        {
            return track + "don't like this: " + track + " pute pute! ;-)";
        }

        // DELETE api/tracks/5
        public string Delete(int id)
        {
            return "easy...No deleting ;-)";
        }
    }
}
