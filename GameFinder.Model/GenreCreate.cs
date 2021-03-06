using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Model
{
    public class GenreCreate
    {
        [Required]
        [MinLength (2, ErrorMessage ="Please enter at least 2 characters.")]
        [MaxLength (50, ErrorMessage ="There are too many characters in this field.")]
        public string Name { get; set; }
    }
}
