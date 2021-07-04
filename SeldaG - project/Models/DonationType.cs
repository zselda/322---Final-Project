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
        public string Name { get; set; }
        

    }
}
