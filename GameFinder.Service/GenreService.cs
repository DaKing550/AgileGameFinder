using GameFinder.Data;
using GameFinder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Service
{
   public class GenreService
    {
        private readonly Guid _userId;

        public GenreService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateGenre (GenreCreate genre)
        {
            var entity = new Genre()
            {
                OwnerId = _userId,
                Name = genre.Name
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Genres.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GenreListItem> GetGenres()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Genres.Where(g => g.OwnerId == _userId).Select(g => new GenreListItem
                {
                    GenreId = g.GenreId,
                    Name = g.Name
                });

                return query.ToArray();
            }
        }

        public GenreDetail GetGenreByName (string name)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Genres.Single(g => g.Name == name.ToLower() && g.OwnerId == _userId);
                return new GenreDetail
                {
                    GenreId = entity.GenreId,
                    Name = entity.Name.ToLower()
                };
            }
        }


    }
}
