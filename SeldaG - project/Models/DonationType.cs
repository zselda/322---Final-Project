using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SeldaG___project.Models
{
    public class DonationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name should be at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "Name should be less than 100 characters.")]
        public string Name { get; set; }
        
        public string Details { get; set; }


    }
}
