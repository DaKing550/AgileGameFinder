using GameFinder.Model;
using GameFinder.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameFinder.Controllers
{
    [Authorize]
    public class GenreController : ApiController
    {
        private GenreService CreateGenreService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var genreService = new GenreService(userId);
            return genreService;
        }

        public IHttpActionResult Get()
        {
            GenreService genreService = CreateGenreService();
            var genres = genreService.GetGenres();
            return Ok(genres);
        }

        public IHttpActionResult Post(GenreCreate genre)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGenreService();

            if (!service.CreateGenre(genre))
                return InternalServerError();

            return Ok("You successfully created a genre!");
        }

        public IHttpActionResult Get (string name)
        {
            GenreService genreService = CreateGenreService();
            var genre = genreService.GetGenreByName(name);
            return Ok(genre);
        }

        public IHttpActionResult Put (GenreEdit genre)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGenreService();

            if (!service.UpdateGenre(genre))
                return InternalServerError();

            return Ok("You genre waa successfuly updated!");


        }
    }
}
