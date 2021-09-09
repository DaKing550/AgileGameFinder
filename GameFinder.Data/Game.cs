using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 964dba9461638b9a2249f2dc8e549b9d12b4aa88
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
<<<<<<< HEAD
    public class Game
    {
        public int GameId { get; set; }
=======
    class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string Title { get; set; }
        
>>>>>>> 964dba9461638b9a2249f2dc8e549b9d12b4aa88
    }
}
