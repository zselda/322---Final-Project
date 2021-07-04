using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SeldaG___project.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name should be at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "Name should be less than 100 characters.")]
        public string Name { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name should be at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "Name should be less than 100 characters.")]
        public string Details { get; set; }

    }
}
