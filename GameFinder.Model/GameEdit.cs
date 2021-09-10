using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Model
{
    public class GameEdit
    {
        public int GameId { get; set; }
        public string Title { get; set; }

        public string Game { get; set; }

    }
}
