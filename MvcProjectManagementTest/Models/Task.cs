using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjectManagementTest.Models
{
    public enum TaskStatus
    {
        NotStarted,
        InProcess,
        Done,
        Delayed,
    }

    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan PlannedTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TaskStatus Status { get; set; }
        
    }
}