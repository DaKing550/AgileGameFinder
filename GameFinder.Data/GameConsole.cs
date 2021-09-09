using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
    public class GameConsole
    {
        [Key]
        public int ConsoleID { get; set; }
        [Required]
        public string ConsoleName { get; set; }

    }
}
