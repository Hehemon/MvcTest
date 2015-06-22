using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace MvcProjectManagementTest.Models
{
    public enum TaskStatus
    {
        [Display(Name = "Not started")]
        NotStarted,
        [Display(Name = "In Process")]
        InProcess,
        [Display(Name = "Done")]
        Done,
        [Display(Name = "Delayed")]
        Delayed,
    }

    public class ProductTask
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 4)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Planned Time"), DataType(DataType.Duration)]
        [Required]
        public TimeSpan PlannedTime { get; set; }

        [Display(Name = "Start Time"), DataType(DataType.DateTime)]
        [Required]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time"), DataType(DataType.DateTime)]
        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        public Performer Performer { get; set; }
        
    }
}