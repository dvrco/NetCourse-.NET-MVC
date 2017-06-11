using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetCourse.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [Required(ErrorMessage = "Pole Nazwa jest wymagane")]
        [MaxLength(50, ErrorMessage = "Dlugosc nazwy to maxymalnie 50 znakow")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Dlugosc nazwy to maxymalnie 50 znakow")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

    }
}