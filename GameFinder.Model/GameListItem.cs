using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class GameListItem
    {
        public int GameId { get; set; }
        public string Title { get; set; }

        public Guid GamesId { get; set; }

    }
}
