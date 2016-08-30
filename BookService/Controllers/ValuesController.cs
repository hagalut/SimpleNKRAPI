using BookService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookService.Controllers
{
    

    public class ValuesController : ApiController
    {
        // http://lyt.kristennetradio.dk:8000/;
        private Track track = new Track()
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

        // GET api/values
        public Track Get()
        {
            return track;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return value + " <--That??  nope! Dream on....";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return value + "don't like this: "+ value + " pute pute! ;-)";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "easy...No deleting ;-)";
        }
    }
}
