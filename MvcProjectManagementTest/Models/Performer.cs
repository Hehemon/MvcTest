using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProjectManagementTest.Models
{
    public class Performer
    {
        public int Id { get; set; }

        [StringLength(45, MinimumLength = 4)]
        [Required]
        public string Surname { get; set; }

        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string MiddleName { get; set; }
    }
}