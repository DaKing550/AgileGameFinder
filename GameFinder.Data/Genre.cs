using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
    public enum GenreName { Sandbox = 1, RTS, Shooters, MOBA, RolePlaying, Simulation, Puzzlers, Action}

    public class Genre
    {
        public int GenreId { get; set; }
        public GenreName Name { get; set; }
        public int GameId { get; set; }
    }
}
