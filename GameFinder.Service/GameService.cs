using GameFinder.Data;
using GameFinder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Service
{
    public class GameService
    {

        private readonly Guid _userId;
        private readonly Guid _gameId;

        public GameService(Guid gameId)
        {
            _gameId = gameId;
        }
        public bool CreateGame(GameCreate game)
        {
            var entity =
                new Game()
                {                   
                    GameId = game.GameId,
                    Title = game.Title
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
        public IEnumerable<GameListItem> GetGames()
        {            
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games.Where(a => a.GamesId == _gameId).Select(a => new GameListItem
                {
                    GameId = a.GameId,
                    Title = a.Title,
                });
                return query.ToArray();
            }
        }
        public GameDetail GetGameById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(r => r.GameId == id);
                return
                    new GameDetail
                    {
                        GameId = entity.GameId,
                        Title = entity.Title,                        
                    };
            }
        }

        public bool UpdateGame(GameEdit game)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Games.Single(r => r.GameId == game.GameId);
               
                entity.Title = game.Title;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteGame(int gameId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(r => r.GameId == gameId);

                ctx.Games.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }

}
