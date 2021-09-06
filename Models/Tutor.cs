using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_Web_API.Models
{
    public class Tutor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tutor_Name { get; set; }
        public string Email { get;set; }
        public string Mobile { get; set; }
        public string Address { get; set;  }

    }
}
