using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Required(ErrorMessage = "Please select a Genre")]
        public byte GenreId { get; set; }
    }
}